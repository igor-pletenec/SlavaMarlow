using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameScore : MonoBehaviour
{
    public int comboValue;
    private int maxComboValue;

    public Text score;

    void Start()
    {
        score.text = (PlayerPrefs.GetInt("Combo").ToString());

        comboValue = PlayerPrefs.GetInt("Combo");
        maxComboValue = PlayerPrefs.GetInt("maxCombo");

        if (comboValue > maxComboValue)
        {
            PlayerPrefs.SetInt("maxCombo", comboValue);
        }
    }
}
