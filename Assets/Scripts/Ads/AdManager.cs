using UnityEngine;
using SuperOffRoad.GameManager;

namespace SuperOffRoad.Ads
{
    public class AdManager : MonoBehaviour
    {
        public static AdManager Instance { get; private set; }

        [SerializeField] private int AD_SHOW_FREQUENCY = 3; // Mostrar ad cada 3 carreras
        private int racesCount = 0;

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

        public void OnRaceComplete()
        {
            racesCount++;

            if (PlayerData.Instance.HasNoAds())
                return;

            if (racesCount >= AD_SHOW_FREQUENCY)
            {
                ShowAd();
                racesCount = 0;
            }
        }

        public void ShowAd()
        {
            // Aquí se integraría Google Mobile Ads SDK
            // o Unity Ads SDK
            Debug.Log("[AdManager] Mostrando anuncio...");
            
            // Ejemplo de integración con Google Mobile Ads:
            // if (MobileAds.RaiseAdEventsOnUnityThread)
            // {
            //     bannerView.LoadAd(createAdRequest());
            // }
        }

        public void ShowRewardedAd()
        {
            Debug.Log("[AdManager] Mostrando anuncio recompensado...");
            // Agregar lógica de ad recompensado aquí
        }
    }
}
