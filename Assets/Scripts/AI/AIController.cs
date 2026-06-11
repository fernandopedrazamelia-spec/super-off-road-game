using UnityEngine;
using System.Collections;

namespace SuperOffRoad.AI
{
    public class AIController : MonoBehaviour
    {
        [Header("Movement")]
        [SerializeField] private float acceleration = 12f;
        [SerializeField] private float maxSpeed = 22f;
        [SerializeField] private float friction = 8f;
        [SerializeField] private float rotationSpeed = 180f;

        [Header("AI Behavior")]
        [SerializeField] private float pathfindingDistance = 15f;
        [SerializeField] private float reactionTime = 0.5f;
        [SerializeField] private float difficulty = 1f; // 0.8 = easy, 1f = medium, 1.2 = hard

        private Rigidbody2D rb;
        private float currentSpeed = 0f;
        private float currentMaxSpeed;
        private Vector2 targetDirection = Vector2.up;
        private float nextDecisionTime = 0f;

        private void Start()
        {
            rb = GetComponent<Rigidbody2D>();
            currentMaxSpeed = maxSpeed * difficulty;
            nextDecisionTime = Time.time + reactionTime;
        }

        private void Update()
        {
            if (Time.time >= nextDecisionTime)
            {
                MakeAIDecision();
                nextDecisionTime = Time.time + reactionTime;
            }

            RotateCar();
        }

        private void FixedUpdate()
        {
            MoveCar();
            ApplyFriction();
        }

        private void MakeAIDecision()
        {
            // Detectar obstáculos adelante
            RaycastHit2D[] hitsForward = Physics2D.RaycastAll(transform.position, transform.up, pathfindingDistance);
            
            bool obstacleAhead = false;
            foreach (var hit in hitsForward)
            {
                if (hit.collider != null && hit.collider.CompareTag("Obstacle"))
                {
                    obstacleAhead = true;
                    break;
                }
            }

            // Lógica de evasión
            if (obstacleAhead)
            {
                RaycastHit2D hitLeft = Physics2D.Raycast(transform.position, -transform.right, 5f);
                RaycastHit2D hitRight = Physics2D.Raycast(transform.position, transform.right, 5f);

                if (!hitLeft.collider)
                    targetDirection = -transform.right;
                else if (!hitRight.collider)
                    targetDirection = transform.right;
            }
            else
            {
                // Mantener curso recto
                targetDirection = Vector2.Lerp(targetDirection, transform.up, 0.1f).normalized;
            }
        }

        private void MoveCar()
        {
            currentSpeed += acceleration * Time.fixedDeltaTime;
            currentSpeed = Mathf.Clamp(currentSpeed, 0, currentMaxSpeed);

            Vector2 moveDirection = (Vector2)transform.up * currentSpeed;
            rb.velocity = moveDirection;
        }

        private void RotateCar()
        {
            float targetRotation = Mathf.Atan2(targetDirection.x, targetDirection.y) * Mathf.Rad2Deg;
            float currentRotation = transform.eulerAngles.z;
            
            float rotationDifference = Mathf.DeltaAngle(currentRotation, targetRotation);
            float rotationAmount = Mathf.Clamp(rotationDifference, -rotationSpeed * Time.deltaTime, rotationSpeed * Time.deltaTime);
            
            transform.Rotate(0, 0, -rotationAmount);
        }

        private void ApplyFriction()
        {
            currentSpeed = Mathf.Lerp(currentSpeed, currentMaxSpeed * 0.8f, friction * Time.fixedDeltaTime);
        }

        public float GetCurrentSpeed() => currentSpeed;
        public Vector3 GetPosition() => transform.position;
    }
}
