using UnityEngine;

namespace SuperOffRoad.Tracks
{
    public class Obstacle : MonoBehaviour
    {
        public ObstacleType obstacleType = ObstacleType.Rock;
        [SerializeField] private float damageAmount = 10f;
        [SerializeField] private float slowDownDuration = 2f;
        [SerializeField] private float slowDownFactor = 0.5f;

        private bool playerHitThisFrame = false;
        private float hitCooldown = 0f;

        private void Update()
        {
            if (hitCooldown > 0)
                hitCooldown -= Time.deltaTime;

            playerHitThisFrame = false;
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.CompareTag("Player") && !playerHitThisFrame && hitCooldown <= 0)
            {
                OnPlayerCollision(collision);
                playerHitThisFrame = true;
                hitCooldown = 0.5f;
            }
        }

        private void OnPlayerCollision(Collider2D collision)
        {
            Player.PlayerController playerController = collision.GetComponent<Player.PlayerController>();
            if (playerController != null)
            {
                switch (obstacleType)
                {
                    case ObstacleType.Rock:
                    case ObstacleType.Boulder:
                        SlowDownPlayer(playerController);
                        PlayCollisionEffect();
                        break;

                    case ObstacleType.Tree:
                    case ObstacleType.Log:
                        SlowDownPlayer(playerController);
                        PlayCollisionEffect();
                        break;

                    case ObstacleType.Mud:
                    case ObstacleType.Sand:
                        SlowDownPlayer(playerController);
                        break;

                    case ObstacleType.Water:
                        SlowDownPlayer(playerController);
                        break;

                    case ObstacleType.Ice:
                        break;

                    case ObstacleType.Cactus:
                    case ObstacleType.Lava:
                        SlowDownPlayer(playerController);
                        break;

                    case ObstacleType.Vines:
                        SlowDownPlayer(playerController);
                        break;
                }

                Debug.Log($"Jugador chocó con: {obstacleType}");
            }
        }

        private void SlowDownPlayer(Player.PlayerController playerController)
        {
            Debug.Log($"Jugador desacelerado por: {obstacleType}");
        }

        private void PlayCollisionEffect()
        {
            Debug.Log($"Efecto de colisión: {obstacleType}");
        }

        public ObstacleType GetObstacleType() => obstacleType;
    }
}
