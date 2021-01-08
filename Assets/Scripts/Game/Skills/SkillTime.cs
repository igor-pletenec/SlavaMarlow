using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillTime : MonoBehaviour
{
    float timedWorkTime;
    float timedWorkTimeInt;

    public Text timeTime;
    public GameObject backTime;
    public GameObject time;

    private int startWork;

    public Animator timeAnimator;

    private void Start()
    {
        timedWorkTimeInt = PlayerPrefs.GetInt("TimeSkill");
        timedWorkTime = 11.0f + timedWorkTimeInt;
    }

    private void Update()
    {
        if (startWork == 1)
        {
            timedWorkTime -= Time.deltaTime;
            timeTime.text = ((int)timedWorkTime).ToString();

            backTime.gameObject.SetActive(true);
            timeTime.gameObject.SetActive(true);
            time.gameObject.SetActive(true);

            PlayerPrefs.SetInt("SlowSpeed", 1);
            timeAnimator.SetTrigger("startTime");

            if (timedWorkTime <= 0)
            {
                PlayerPrefs.SetInt("SlowSpeed", 0);
                backTime.gameObject.SetActive(false);
                timeTime.gameObject.SetActive(false);
                startWork = 0;
                timedWorkTime = 11.0f + timedWorkTimeInt;
                timeAnimator.SetTrigger("endTime");
                time.gameObject.SetActive(false);
            }
        }
    }

    public void ActiveTime()
    {
        startWork = 1;
    }

}
