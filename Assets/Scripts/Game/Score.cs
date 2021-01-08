using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text score;

    public int scoreInt;
    public int kills;

    private int killPrevious;
    private int sumKills;

    private void Start()
    {
        killPrevious = PlayerPrefs.GetInt("Kill"); 
    }
    private void Update()
    {
        score.text = scoreInt.ToString();

        PlayerPrefs.SetInt("Combo", scoreInt);

        sumKills = kills + killPrevious;
        PlayerPrefs.SetInt("Kill", sumKills);



    }
}
