using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class First5seconds : MonoBehaviour
{
    public GameObject hearts;
    public GameObject score;
    public GameObject skills;
    public GameObject pandas;

    void Update()
    {
        if (Time.timeSinceLevelLoad < 4.7f)
        {
            hearts.gameObject.SetActive(false);
            score.gameObject.SetActive(false);
            skills.gameObject.SetActive(false);
            pandas.gameObject.SetActive(false);
        }
        else
        {
            hearts.gameObject.SetActive(true);
            score.gameObject.SetActive(true);
            skills.gameObject.SetActive(true);
            pandas.gameObject.SetActive(true);

            enabled = false;
            Destroy(gameObject);
        }
    }
}
