using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;
using System;


public class AdRewarded : MonoBehaviour
{
    private RewardedAd rewarded1;
    private RewardedAd rewarded2;
    private RewardedAd rewarded3;
    private RewardedAd rewarded4;
    private RewardedAd rewarded5;
    private RewardedAd rewarded6;
    private RewardedAd rewarded7;
    private RewardedAd rewarded8;
    private RewardedAd rewarded9;
    private RewardedAd rewarded10;

    public GameObject buttonVideo1;
    public GameObject buttonVideo2;
    public GameObject buttonVideo3;
    public GameObject buttonVideo4;
    public GameObject buttonVideo5;
    public GameObject buttonVideo6;
    public GameObject buttonVideo7;
    public GameObject buttonVideo8;
    public GameObject buttonVideo9;
    public GameObject buttonVideo10;

    public GameObject videoViewed1;
    public GameObject videoViewed2;
    public GameObject videoViewed3;
    public GameObject videoViewed4;
    public GameObject videoViewed5;
    public GameObject videoViewed6;
    public GameObject videoViewed7;
    public GameObject videoViewed8;
    public GameObject videoViewed9;
    public GameObject videoViewed10;

    private GameObject videoViwed;
    private GameObject buttonVideo;

    public int watch;

    public void Start()
    {
        //string adUnitId = "ca-app-pub-3940256099942544/5224354917"; // стандартный идентификатор рекламы за награду
        string adUnitId = "ca-app-pub-5442177896212042/8438957137"; // мой идентификатор рекламы за награду

        this.rewarded1 = CreateAndLoadRewardedAd(adUnitId);
        this.rewarded2 = CreateAndLoadRewardedAd(adUnitId);
        this.rewarded3 = CreateAndLoadRewardedAd(adUnitId);
        this.rewarded4 = CreateAndLoadRewardedAd(adUnitId);
        this.rewarded5 = CreateAndLoadRewardedAd(adUnitId);
        this.rewarded6 = CreateAndLoadRewardedAd(adUnitId);
        this.rewarded7 = CreateAndLoadRewardedAd(adUnitId);
        this.rewarded8 = CreateAndLoadRewardedAd(adUnitId);
        this.rewarded9 = CreateAndLoadRewardedAd(adUnitId);
        this.rewarded10 = CreateAndLoadRewardedAd(adUnitId);
    }

    public RewardedAd CreateAndLoadRewardedAd(string adUnitId)
    {
        RewardedAd rewardedAd = new RewardedAd(adUnitId);

        rewardedAd.OnAdLoaded += HandleRewardedAdLoaded;
        rewardedAd.OnUserEarnedReward += HandleUserEarnedReward;
        rewardedAd.OnAdClosed += HandleRewardedAdClosed;

        // Create an empty ad request.
        AdRequest request = new AdRequest.Builder().Build();
        // Load the rewarded ad with the request.
        rewardedAd.LoadAd(request);
        return rewardedAd;
    }

    public void HandleRewardedAdLoaded(object sender, EventArgs args)
    {
        MonoBehaviour.print("HandleRewardedAdLoaded event received");
    }

    public void HandleRewardedAdFailedToLoad(object sender, AdErrorEventArgs args)
    {
        MonoBehaviour.print(
            "HandleRewardedAdFailedToLoad event received with message: "
                             + args.Message);
    }

    public void HandleRewardedAdOpening(object sender, EventArgs args)
    {
        MonoBehaviour.print("HandleRewardedAdOpening event received");
    }

    public void HandleRewardedAdFailedToShow(object sender, AdErrorEventArgs args)
    {
        MonoBehaviour.print(
            "HandleRewardedAdFailedToShow event received with message: "
                             + args.Message);
    }

    public void HandleRewardedAdClosed(object sender, EventArgs args)
    {
        MonoBehaviour.print("HandleRewardedAdClosed event received");
    }

    public void HandleUserEarnedReward(object sender, Reward args)
    {
        watch++;
        PlayerPrefs.SetInt("Watch", watch);
        buttonVideo.gameObject.SetActive(false);
        videoViwed.gameObject.SetActive(true);
    }

    public void WatchVideo1()
    {
        if (this.rewarded1.IsLoaded())
        {
            this.rewarded1.Show();
        }
        watch = PlayerPrefs.GetInt("Watch");
        buttonVideo = buttonVideo1;
        videoViwed = videoViewed1;
    }

    public void WatchVideo2()
    {
        if (this.rewarded2.IsLoaded())
        {
            this.rewarded2.Show();
        }
        watch = PlayerPrefs.GetInt("Watch");
        buttonVideo = buttonVideo2;
        videoViwed = videoViewed2;
    }

    public void WatchVideo3()
    {
        if (this.rewarded3.IsLoaded())
        {
            this.rewarded3.Show();
        }
        watch = PlayerPrefs.GetInt("Watch");
        buttonVideo = buttonVideo3;
        videoViwed = videoViewed3;
    }

    public void WatchVideo4()
    {
        if (this.rewarded4.IsLoaded())
        {
            this.rewarded4.Show();
        }
        watch = PlayerPrefs.GetInt("Watch");
        buttonVideo = buttonVideo4;
        videoViwed = videoViewed4;
    }

    public void WatchVideo5()
    {
        if (this.rewarded5.IsLoaded())
        {
            this.rewarded5.Show();
        }
        watch = PlayerPrefs.GetInt("Watch");
        buttonVideo = buttonVideo5;
        videoViwed = videoViewed5;
    }

    public void WatchVideo6()
    {
        if (this.rewarded6.IsLoaded())
        {
            this.rewarded6.Show();
        }
        watch = PlayerPrefs.GetInt("Watch");
        buttonVideo = buttonVideo6;
        videoViwed = videoViewed6;
    }

    public void WatchVideo7()
    {
        if (this.rewarded7.IsLoaded())
        {
            this.rewarded7.Show();
        }
        watch = PlayerPrefs.GetInt("Watch");
        buttonVideo = buttonVideo7;
        videoViwed = videoViewed7;
    }

    public void WatchVideo8()
    {
        if (this.rewarded8.IsLoaded())
        {
            this.rewarded8.Show();
        }
        watch = PlayerPrefs.GetInt("Watch");
        buttonVideo = buttonVideo8;
        videoViwed = videoViewed8;
    }

    public void WatchVideo9()
    {
        if (this.rewarded9.IsLoaded())
        {
            this.rewarded9.Show();
        }
        watch = PlayerPrefs.GetInt("Watch");
        buttonVideo = buttonVideo9;
        videoViwed = videoViewed9;
    }

    public void WatchVideo10()
    {
        if (this.rewarded10.IsLoaded())
        {
            this.rewarded10.Show();
        }
        watch = PlayerPrefs.GetInt("Watch");
        buttonVideo = buttonVideo10;
        videoViwed = videoViewed10;
    }
}
