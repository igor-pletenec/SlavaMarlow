using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WiFi : MonoBehaviour
{
    public GameObject checkWiFi;
    public GameObject helpText;

    void Update()
    {
        if (Application.internetReachability == NetworkReachability.NotReachable) //если нет инета
        {
            checkWiFi.gameObject.SetActive(true);
            helpText.gameObject.SetActive(false);
        }
        else
        {
            checkWiFi.gameObject.SetActive(false); //если есть инет
            helpText.gameObject.SetActive(true);
        }
    }
}
