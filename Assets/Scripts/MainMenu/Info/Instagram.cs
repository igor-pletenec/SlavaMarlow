using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instagram : MonoBehaviour
{
    public void OpenURLIgor(string url)
    {
        Application.OpenURL(url);
    }
    
    public void OpenURLNatasha(string url)
    {
        Application.OpenURL(url);
    }

    public void OpenURLSlava(string url)
    {
        Application.OpenURL(url);
    }

    public void Back()
    {
        PlayerPrefs.Save();
    }
}
