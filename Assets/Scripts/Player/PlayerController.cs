using UnityEngine;
using UnityEngine.InputSystem;

namespace SuperOffRoad.Player
{
    public class PlayerController : MonoBehaviour
    {
        [Header("Movement")]
        [SerializeField] private float acceleration = 15f;
        [SerializeField] private float maxSpeed = 25f;
        [SerializeField] private float friction = 8f;
        [SerializeField] private float rotationSpeed = 200f;
        [SerializeField] private float driftFactor = 0.8f;

        [Header("Terrain Effects")]
        [SerializeField] private float mudSpeedModifier = 0.6f;
        [SerializeField] private float sandSpeedModifier = 0.7f;
        [SerializeField] private float stoneSpeedModifier = 0.9f;

        private Rigidbody2D rb;
        private Vector2 moveInput;
        private float currentSpeed = 0f;
        private float currentMaxSpeed;
        private float driftAmount = 0f;
        private Collider2D currentTerrain;

        private void Start()
        {
            rb = GetComponent<Rigidbody2D>();
            currentMaxSpeed = maxSpeed;
        }

        private void Update()
        {
            HandleInput();
            RotateCar();
        }

        private void FixedUpdate()
        {
            MoveCar();
            ApplyFriction();
        }

        private void HandleInput()
        {
            // Simular input en editor para testing
            #if UNITY_EDITOR
            moveInput = Vector2.zero;
            if (Input.GetKey(KeyCode.Up)) moveInput.y = 1;
            if (Input.GetKey(KeyCode.Down)) moveInput.y = -1;
            if (Input.GetKey(KeyCode.Left)) moveInput.x = -1;
            if (Input.GetKey(KeyCode.Right)) moveInput.x = 1;
            #endif
        }

        private void MoveCar()
        {
            if (moveInput.y > 0)
            {
                currentSpeed += acceleration * Time.fixedDeltaTime;
            }
            else if (moveInput.y < 0)
            {
                currentSpeed -= acceleration * 2f * Time.fixedDeltaTime;
            }

            currentSpeed = Mathf.Clamp(currentSpeed, -currentMaxSpeed * 0.5f, currentMaxSpeed);

            Vector2 moveDirection = (Vector2)transform.up * currentSpeed;
            rb.velocity = moveDirection;
        }

        private void RotateCar()
        {
            if (currentSpeed > 0.5f)
            {
                float rotationInput = moveInput.x;
                float rotation = rotationInput * rotationSpeed * (currentSpeed / currentMaxSpeed) * Time.deltaTime;
                transform.Rotate(0, 0, -rotation);
            }
        }

        private void ApplyFriction()
        {
            if (moveInput.y == 0)
            {
                currentSpeed = Mathf.Lerp(currentSpeed, 0, friction * Time.fixedDeltaTime);
            }
        }

        private void OnTriggerStay2D(Collider2D collision)
        {
            TerrainType terrain = collision.GetComponent<TerrainType>();
            if (terrain != null)
            {
                ApplyTerrainEffect(terrain);
            }
        }

        private void ApplyTerrainEffect(TerrainType terrain)
        {
            switch (terrain.terrainType)
            {
                case TerrainType.Type.Mud:
                    currentMaxSpeed = maxSpeed * mudSpeedModifier;
                    break;
                case TerrainType.Type.Sand:
                    currentMaxSpeed = maxSpeed * sandSpeedModifier;
                    break;
                case TerrainType.Type.Stone:
                    currentMaxSpeed = maxSpeed * stoneSpeedModifier;
                    break;
                case TerrainType.Type.Road:
                    currentMaxSpeed = maxSpeed;
                    break;
            }
        }

        public float GetCurrentSpeed() => currentSpeed;
        public float GetMaxSpeed() => currentMaxSpeed;
        public Vector3 GetPosition() => transform.position;
    }
}
