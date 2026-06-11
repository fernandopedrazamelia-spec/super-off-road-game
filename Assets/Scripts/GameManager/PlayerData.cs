using UnityEngine;

namespace SuperOffRoad.GameManager
{
    public class PlayerData : MonoBehaviour
    {
        public static PlayerData Instance { get; private set; }

        [Header("Player Stats")]
        private int totalPoints = 0;
        private int totalWins = 0;
        private int totalRaces = 0;
        private bool noAdsUnlocked = false;

        [Header("Car Upgrades")]
        private float speedUpgrade = 1f;
        private float gripUpgrade = 1f;
        private float accelerationUpgrade = 1f;

        private void Awake()
        {
            if (Instance != null && Instance != this)
            {
                Destroy(gameObject);
                return;
            }
            Instance = this;
            DontDestroyOnLoad(gameObject);
            LoadPlayerData();
        }

        private void LoadPlayerData()
        {
            // Cargar datos guardados de PlayerPrefs
            totalPoints = PlayerPrefs.GetInt("TotalPoints", 0);
            totalWins = PlayerPrefs.GetInt("TotalWins", 0);
            totalRaces = PlayerPrefs.GetInt("TotalRaces", 0);
            noAdsUnlocked = PlayerPrefs.GetInt("NoAds", 0) == 1;
            
            speedUpgrade = PlayerPrefs.GetFloat("SpeedUpgrade", 1f);
            gripUpgrade = PlayerPrefs.GetFloat("GripUpgrade", 1f);
            accelerationUpgrade = PlayerPrefs.GetFloat("AccelerationUpgrade", 1f);
        }

        public void SavePlayerData()
        {
            PlayerPrefs.SetInt("TotalPoints", totalPoints);
            PlayerPrefs.SetInt("TotalWins", totalWins);
            PlayerPrefs.SetInt("TotalRaces", totalRaces);
            PlayerPrefs.SetInt("NoAds", noAdsUnlocked ? 1 : 0);
            
            PlayerPrefs.SetFloat("SpeedUpgrade", speedUpgrade);
            PlayerPrefs.SetFloat("GripUpgrade", gripUpgrade);
            PlayerPrefs.SetFloat("AccelerationUpgrade", accelerationUpgrade);
            
            PlayerPrefs.Save();
        }

        public void AddPoints(int points)
        {
            totalPoints += points;
            SavePlayerData();
        }

        public void AddWin()
        {
            totalWins++;
            totalRaces++;
            SavePlayerData();
        }

        public void AddRace()
        {
            totalRaces++;
            SavePlayerData();
        }

        public void UpgradeSpeed(int cost)
        {
            if (totalPoints >= cost)
            {
                totalPoints -= cost;
                speedUpgrade += 0.1f;
                SavePlayerData();
            }
        }

        public void UpgradeGrip(int cost)
        {
            if (totalPoints >= cost)
            {
                totalPoints -= cost;
                gripUpgrade += 0.1f;
                SavePlayerData();
            }
        }

        public void UpgradeAcceleration(int cost)
        {
            if (totalPoints >= cost)
            {
                totalPoints -= cost;
                accelerationUpgrade += 0.1f;
                SavePlayerData();
            }
        }

        public void UnlockNoAds()
        {
            noAdsUnlocked = true;
            SavePlayerData();
        }

        // Getters
        public int GetTotalPoints() => totalPoints;
        public int GetTotalWins() => totalWins;
        public int GetTotalRaces() => totalRaces;
        public bool HasNoAds() => noAdsUnlocked;
        
        public float GetSpeedMultiplier() => speedUpgrade;
        public float GetGripMultiplier() => gripUpgrade;
        public float GetAccelerationMultiplier() => accelerationUpgrade;
    }
}
