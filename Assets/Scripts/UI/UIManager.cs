using UnityEngine;
using TMPro;

namespace SuperOffRoad.UI
{
    public class UIManager : MonoBehaviour
    {
        public static UIManager Instance { get; private set; }

        [Header("UI Elements")]
        [SerializeField] private TextMeshProUGUI lapText;
        [SerializeField] private TextMeshProUGUI positionText;
        [SerializeField] private TextMeshProUGUI speedText;
        [SerializeField] private TextMeshProUGUI pointsText;
        [SerializeField] private TextMeshProUGUI timerText;
        
        [Header("Buttons")]
        [SerializeField] private GameObject leftButton;
        [SerializeField] private GameObject rightButton;
        [SerializeField] private GameObject accelerateButton;

        private void Awake()
        {
            if (Instance != null && Instance != this)
            {
                Destroy(gameObject);
                return;
            }
            Instance = this;
        }

        private void Update()
        {
            UpdateUI();
        }

        private void UpdateUI()
        {
            // Actualizar lap
            if (lapText != null)
            {
                int currentLap = GameManager.GameManager.Instance.GetPlayerCurrentLap();
                int totalLaps = GameManager.GameManager.Instance.GetLapsToComplete();
                lapText.text = $"Vuelta: {currentLap}/{totalLaps}";
            }

            // Actualizar puntos
            if (pointsText != null)
            {
                pointsText.text = $"Puntos: {GameManager.PlayerData.Instance.GetTotalPoints()}";
            }

            // Actualizar tiempo
            if (timerText != null)
            {
                float elapsedTime = GameManager.GameManager.Instance.GetRaceElapsedTime();
                int minutes = (int)(elapsedTime / 60);
                int seconds = (int)(elapsedTime % 60);
                timerText.text = $"Tiempo: {minutes:00}:{seconds:00}";
            }
        }

        public void UpdateSpeed(float speed)
        {
            if (speedText != null)
                speedText.text = $"Velocidad: {speed:F1}";
        }

        public void UpdatePosition(int position, int totalRacers)
        {
            if (positionText != null)
                positionText.text = $"Posición: {position}/{totalRacers}";
        }

        public void ShowGameOver(string message)
        {
            Debug.Log($"Game Over: {message}");
            // Aquí iría la lógica para mostrar el GameOver
        }
    }
}
