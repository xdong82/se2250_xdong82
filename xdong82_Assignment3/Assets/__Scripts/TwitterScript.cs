using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwitterScript : MonoBehaviour
{
    private const string TWITTER_ADDRESS = "http://twitter.com/intent/tweet";
    private const string TWEET_LANGUAGE = "en";
    public static string descriptionParam;
    private string appStoreLink = "http://www.YOUROWNAPPLINK.com";

    public void ShareToTW(string linkParameter)
    {

        string nameParameter = "Your High Score: " + ScoreManager.HIGH_SCORE;//this is limited in text length 
        Application.OpenURL(TWITTER_ADDRESS +
           "?text=" + WWW.EscapeURL(nameParameter));
    }
}
