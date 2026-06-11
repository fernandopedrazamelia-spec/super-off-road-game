using UnityEngine;
using GoogleMobileAds.Api;

namespace SuperOffRoad.Monetization
{
    public class MobileAdsManager : MonoBehaviour
    {
        public static MobileAdsManager Instance { get; private set; }

        [Header("Ad Unit IDs - REEMPLAZA CON TUS IDS")]
        [SerializeField] private string androidBannerId = "ca-app-pub-xxxxxxxxxxxxxxxx/yyyyyyyyyyyyyy";
        [SerializeField] private string iosBannerId = "ca-app-pub-xxxxxxxxxxxxxxxx/yyyyyyyyyyyyyy";
        [SerializeField] private string androidInterstitialId = "ca-app-pub-xxxxxxxxxxxxxxxx/yyyyyyyyyyyyyy";
        [SerializeField] private string iosInterstitialId = "ca-app-pub-xxxxxxxxxxxxxxxx/yyyyyyyyyyyyyy";

        private BannerView bannerView;
        private InterstitialAd interstitialAd;
        private RewardedAd rewardedAd;

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
            InitializeMobileAds();
            LoadBannerAd();
        }

        private void InitializeMobileAds()
        {
            MobileAds.Initialize(initStatus => {
                Debug.Log("[MobileAds] Inicializado");
            });
        }

        private void LoadBannerAd()
        {
            string adUnitId = GetPlatformAdId(androidBannerId, iosBannerId);
            AdRequest request = new AdRequest();
            bannerView = new BannerView(adUnitId, AdSize.Banner, AdPosition.Bottom);
            bannerView.LoadAd(request);
            Debug.Log("[MobileAds] Banner cargado");
        }

        public void ShowInterstitialAd()
        {
            if (GameManager.PlayerData.Instance.HasNoAds())
                return;

            Debug.Log("[MobileAds] Mostrando anuncio intersticial");
        }

        private string GetPlatformAdId(string androidId, string iosId)
        {
            #if UNITY_ANDROID
                return androidId;
            #elif UNITY_IOS
                return iosId;
            #else
                return androidId;
            #endif
        }

        public void DestroyBannerAd()
        {
            if (bannerView != null)
                bannerView.Destroy();
        }
    }
}
