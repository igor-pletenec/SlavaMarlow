using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfoScore : MonoBehaviour
{
    private int comboValue;
    private int maxComboValue;

    public Text maxScore;

    void FixedUpdate()
    {
        comboValue = PlayerPrefs.GetInt("Combo");
        maxComboValue = PlayerPrefs.GetInt("maxCombo");

        if (comboValue > maxComboValue)
        {
            maxScore.text = comboValue.ToString();
            PlayerPrefs.SetInt("maxCombo", comboValue);
        }
        else
        {
            maxScore.text = maxComboValue.ToString();
        }
    }
}
