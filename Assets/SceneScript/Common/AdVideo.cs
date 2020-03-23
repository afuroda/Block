using System;
using System.Collections;
using GoogleMobileAds.Api;
using UnityEngine;
using UnityEngine.SceneManagement;
public class AdVideo : MonoBehaviour
{

    private InterstitialAd _interstitial;

    private bool shown = false;

    // Use this for initialization

    void Start()
    {

        // 起動時にインタースティシャル広告をロードしておく

        string appId = "ca-app-pub-5719821723126134~6154154702";

        // Initialize the Google Mobile Ads SDK.
        MobileAds.Initialize(appId);

        RequestInterstitial();
    }


    public void RequestInterstitial()
    {
        string adUnitId = "ca-app-pub-5719821723126134/9125547377";

        // Initialize an InterstitialAd.

        this._interstitial = new InterstitialAd(adUnitId);

        // Create an empty ad request.

        AdRequest request = new AdRequest.Builder().Build();

        this._interstitial.OnAdClosed += HandleOnAdClosed;

        // Load the interstitial with the request.

        this._interstitial.LoadAd(request);
    }

    public void Update()
    {
        if (shown == false)
        {
            ShowInterstitial();
            Debug.Log("Not yet...");
        }
    }

    public void ShowInterstitial()
    {
        if (_interstitial.IsLoaded())
        {
            _interstitial.Show();
            shown = true;
        }
        else
        {
            Debug.Log("Interstitial is not ready yet.");
        }
    }

    public void HandleOnAdClosed(object sender, EventArgs args)
    {
        Debug.Log("HandleAdClosed event received");
        SceneManager.LoadScene("Scene1");
    }

}