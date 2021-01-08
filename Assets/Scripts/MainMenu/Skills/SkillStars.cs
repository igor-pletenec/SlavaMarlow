using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillStars : MonoBehaviour
{
    public Text skillStars;

    public int starsInt;

    private void Awake()
    {
        starsInt = PlayerPrefs.GetInt("Stars");
    }

    private void FixedUpdate()
    {
        skillStars.text = starsInt.ToString();

        PlayerPrefs.SetInt("Stars", starsInt);
    }

    public void Back()
    {
        PlayerPrefs.Save();
    }
}
