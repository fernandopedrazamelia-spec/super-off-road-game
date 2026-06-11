using UnityEngine;
using SuperOffRoad.GameManager;

namespace SuperOffRoad.Utils
{
    public class FinishLine : MonoBehaviour
    {
        [SerializeField] private bool isStartLine = false;
        private bool playerCrossedStartLine = false;
        private Player.PlayerController playerController;

        private void Start()
        {
            playerController = FindObjectOfType<Player.PlayerController>();
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.CompareTag("Player"))
            {
                if (isStartLine)
                {
                    playerCrossedStartLine = true;
                }
                else if (playerCrossedStartLine)
                {
                    GameManager.Instance.CompleteLap();
                    playerCrossedStartLine = false;
                }
            }
        }
    }
}
