using System;
using System.Collections;
using System.Collections.Generic;
using GoogleMobileAds.Api;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Stage21Methods : MonoBehaviour
{
    // Start is called before the first frame update
    private InterstitialAd _interstitial;

    private bool shown = false;
    // Start is called before the first frame update
    void Start()
    {　 // 起動時にインタースティシャル広告をロードしておく

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
        _interstitial.Destroy();
        SceneManager.LoadScene("Scene22");
    }

    // Update is called once per frame

    public void OnClick()
    {
        int value = UnityEngine.Random.Range(0, 2 + 1);
        if (value == 0)
        {
            ShowInterstitial();
        }
        else if (value == 1)
        {

            SceneManager.LoadScene("Scene22");
        }
    }
}