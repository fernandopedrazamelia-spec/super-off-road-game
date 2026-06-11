using UnityEngine;
using System.Collections.Generic;

namespace SuperOffRoad.GameManager
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager Instance { get; private set; }

        [Header("Game Settings")]
        [SerializeField] private int lapsToComplete = 3;
        [SerializeField] private int numberOfAIOpponents = 4;
        [SerializeField] private float raceTimeout = 600f; // 10 minutos

        [Header("Race Data")]
        private Dictionary<int, RaceData> racerData = new Dictionary<int, RaceData>();
        private bool raceActive = false;
        private float raceStartTime = 0f;
        private int playerLaps = 0;
        private int playerCurrentLap = 1;

        private void Awake()
        {
            if (Instance != null && Instance != this)
            {
                Destroy(gameObject);
                return;
            }
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }

        private void Start()
        {
            InitializeRace();
        }

        private void Update()
        {
            if (raceActive)
            {
                UpdateRaceTimer();
                CheckRaceEnd();
            }
        }

        private void InitializeRace()
        {
            raceActive = true;
            raceStartTime = Time.time;
            playerLaps = 0;
            playerCurrentLap = 1;
        }

        private void UpdateRaceTimer()
        {
            float elapsedTime = Time.time - raceStartTime;
            
            if (elapsedTime > raceTimeout)
            {
                EndRace(false);
            }
        }

        private void CheckRaceEnd()
        {
            if (playerLaps >= lapsToComplete)
            {
                EndRace(true);
            }
        }

        public void CompleteLap()
        {
            playerLaps++;
            playerCurrentLap++;
        }

        public void EndRace(bool playerWon)
        {
            raceActive = false;
            
            if (playerWon)
            {
                AddPointsToPlayer(100);
                Debug.Log("¡Victoria! +100 puntos");
            }
            else
            {
                Debug.Log("Carrera terminada. Tiempo agotado.");
            }
        }

        private void AddPointsToPlayer(int points)
        {
            PlayerData.Instance.AddPoints(points);
        }

        public bool IsRaceActive() => raceActive;
        public int GetPlayerCurrentLap() => playerCurrentLap;
        public int GetLapsToComplete() => lapsToComplete;
        public float GetRaceElapsedTime() => Time.time - raceStartTime;
    }

    public struct RaceData
    {
        public int laps;
        public float bestLapTime;
        public float totalTime;
        public int position;
    }
}
