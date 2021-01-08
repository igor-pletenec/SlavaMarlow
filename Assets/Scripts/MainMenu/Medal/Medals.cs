using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Medals : MonoBehaviour
{
    private int levelWatch;
    private int levelEnter;
    private int levelKill;
    private int levelCombo;
    private int levelMedal;

    private int sumOfAwards;

    void FixedUpdate()
    {
        levelCombo = PlayerPrefs.GetInt("LevelCombo");
        levelEnter = PlayerPrefs.GetInt("LevelEnter");
        levelKill = PlayerPrefs.GetInt("LevelKill");
        levelMedal = PlayerPrefs.GetInt("LevelMedal");
        levelWatch = PlayerPrefs.GetInt("LevelWatch");

        sumOfAwards = levelCombo + levelEnter + levelKill + levelMedal + levelWatch;

        PlayerPrefs.SetInt("Medal", sumOfAwards);
    }
}
