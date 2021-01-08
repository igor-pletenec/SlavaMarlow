using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checking : MonoBehaviour
{
    public int watch;
    public int enter;
    public int kill;
    public int combo;
    public int stars;


    void FixedUpdate()
    {
        watch = PlayerPrefs.GetInt("Watch");
        enter = PlayerPrefs.GetInt("Enter");
        kill = PlayerPrefs.GetInt("Kill");
        combo = PlayerPrefs.GetInt("Combo");
    }

    public void PlayVideoTest()
    {
        watch++;
        PlayerPrefs.SetInt("Watch", watch);
        enter++;
        PlayerPrefs.SetInt("Enter", enter);
        kill++;
        PlayerPrefs.SetInt("Kill", kill);
        combo++;
        PlayerPrefs.SetInt("Combo", combo);
    }

    public void DeletePlayerPrefs()
    {
        PlayerPrefs.SetInt("Stars", 0);
        PlayerPrefs.DeleteAll();
        PlayerPrefs.Save();
    }
}
