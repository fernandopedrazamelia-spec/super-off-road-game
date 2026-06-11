using UnityEngine;
using SuperOffRoad.GameManager;

namespace SuperOffRoad.Shop
{
    public class ShopManager : MonoBehaviour
    {
        [Header("Upgrade Prices")]
        [SerializeField] private int speedUpgradePrice = 50;
        [SerializeField] private int gripUpgradePrice = 50;
        [SerializeField] private int accelerationUpgradePrice = 50;
        [SerializeField] private int removeAdsPrice = 200;

        public void BuySpeedUpgrade()
        {
            PlayerData.Instance.UpgradeSpeed(speedUpgradePrice);
            Debug.Log("¡Velocidad mejorada!");
        }

        public void BuyGripUpgrade()
        {
            PlayerData.Instance.UpgradeGrip(gripUpgradePrice);
            Debug.Log("¡Agarre mejorado!");
        }

        public void BuyAccelerationUpgrade()
        {
            PlayerData.Instance.UpgradeAcceleration(accelerationUpgradePrice);
            Debug.Log("¡Aceleración mejorada!");
        }

        public void BuyRemoveAds()
        {
            // Aquí se integraría con un sistema de compra in-app real
            // (Google Play Billing, App Store, etc.)
            
            PlayerData.Instance.UnlockNoAds();
            Debug.Log("¡Anuncios eliminados!");
        }

        public int GetSpeedUpgradePrice() => speedUpgradePrice;
        public int GetGripUpgradePrice() => gripUpgradePrice;
        public int GetAccelerationUpgradePrice() => accelerationUpgradePrice;
        public int GetRemoveAdsPrice() => removeAdsPrice;
    }
}
