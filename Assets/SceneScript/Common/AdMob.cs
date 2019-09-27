using System.Collections;
using System.Collections.Generic;
using GoogleMobileAds.Api;
using UnityEngine;

public class AdMob : MonoBehaviour {

    // Use this for initialization
    void Start () {

        // 本番では自身のアプリIDを設定します
        string appId = "ca-app-pub-3940256099942544~3347511713";

        // Initialize the Google Mobile Ads SDK.
        MobileAds.Initialize (appId);

        this.RequestBanner ();
    }

    private void RequestBanner () {
        // 本番では　自身の広告ユニットIDを設定します
        string adUnitId = "ca-app-pub-3940256099942544/2934735716";

        // Create a 320x50 banner at the top of the screen.
        BannerView bannerView = new BannerView (adUnitId, AdSize.Banner, AdPosition.Bottom);
        // Create an empty ad request.
        AdRequest request = new AdRequest.Builder ().Build ();
        // Load the banner with the request.
        bannerView.LoadAd (request);

    }

    // Update is called once per frame
    void Update () {

    }
}