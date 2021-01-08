using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillShield : MonoBehaviour
{
    float shieldWorkTime;
    float shieldWorkTimeInt;

    public GameObject timeShield;
    public GameObject shield;
    public Text shielTime;
    public Animator shieldAnimator;

    private int startWork;

    private void Start()
    {
        shieldWorkTimeInt = PlayerPrefs.GetInt("ShieldSkill");
        shieldWorkTime = 3.0f + shieldWorkTimeInt;
    }

    private void Update()
    {
        if (startWork == 1)
        {
            shieldWorkTime -= Time.deltaTime;
            shielTime.text = ((int)shieldWorkTime).ToString();

            timeShield.gameObject.SetActive(true);
            shield.SetActive(true);

            shieldAnimator.SetTrigger("startShield");

            if (shieldWorkTime <= 0)
            {
                shield.SetActive(false);
                timeShield.gameObject.SetActive(false);
                startWork = 0;
                shieldWorkTime = 3.0f + shieldWorkTimeInt;
                shieldAnimator.SetTrigger("endShield");
            }
        }
    }

    public void ActiveShield()
    {
        startWork = 1;
    }
}
