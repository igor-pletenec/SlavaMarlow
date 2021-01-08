using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillChoose : MonoBehaviour
{
    public GameObject buttonAttackActive;
    public GameObject buttonShieldActive;
    public GameObject buttonTimeActive;

    public Button buttonAttackDeActive;
    public Button buttonShieldDeActive;
    public Button buttonTimeDeActive;

    private int openAttack;
    private int openShield;
    private int openTime;
    private int chooseSkill;

    public AudioSource skillAudioSource;
    public AudioClip skillChooseClip;

    private void Start()
    {
        if (PlayerPrefs.GetInt("SkillChoose") == 1)
        {
            buttonAttackDeActive.gameObject.SetActive(false);
            buttonAttackActive.SetActive(true);
        }

        if (PlayerPrefs.GetInt("SkillChoose") == 2)
        {
            buttonShieldDeActive.gameObject.SetActive(false);
            buttonShieldActive.SetActive(true);
        }

        if (PlayerPrefs.GetInt("SkillChoose") == 3)
        {
            buttonTimeDeActive.gameObject.SetActive(false);
            buttonTimeActive.SetActive(true);
        }
    }

    void FixedUpdate()
    {
        openAttack = PlayerPrefs.GetInt("AttackSkill");
        openShield = PlayerPrefs.GetInt("ShieldSkill");
        openTime = PlayerPrefs.GetInt("TimeSkill");

        if (openAttack < 1)
        {
            buttonAttackDeActive.enabled = false;
        }
        else
        {
            buttonAttackDeActive.enabled = true;
        }

        if (openShield < 1)
        {
            buttonShieldDeActive.enabled = false;
        }
        else
        {
            buttonShieldDeActive.enabled = true;
        }

        if (openTime < 1)
        {
            buttonTimeDeActive.enabled = false;
        }
        else
        {
            buttonTimeDeActive.enabled = true;
        }
    }

    // Attack = 1, Shield = 2, Time = 3.

    public void ChooseAttack()
    {
        PlayerPrefs.SetInt("SkillChoose", 1);
        buttonAttackDeActive.gameObject.SetActive(false);
        buttonShieldDeActive.gameObject.SetActive(true);
        buttonTimeDeActive.gameObject.SetActive(true);
        buttonAttackActive.SetActive(true);
        buttonShieldActive.SetActive(false);
        buttonTimeActive.SetActive(false);
        skillAudioSource.PlayOneShot(skillChooseClip);
    }

    public void ChooseShield()
    {
        PlayerPrefs.SetInt("SkillChoose", 2);
        buttonAttackDeActive.gameObject.SetActive(true);
        buttonShieldDeActive.gameObject.SetActive(false);
        buttonTimeDeActive.gameObject.SetActive(true);
        buttonAttackActive.SetActive(false);
        buttonShieldActive.SetActive(true);
        buttonTimeActive.SetActive(false);
        skillAudioSource.PlayOneShot(skillChooseClip);
    }

    public void ChooseTime()
    {
        PlayerPrefs.SetInt("SkillChoose", 3);
        buttonAttackDeActive.gameObject.SetActive(true);
        buttonShieldDeActive.gameObject.SetActive(true);
        buttonTimeDeActive.gameObject.SetActive(false);
        buttonAttackActive.SetActive(false);
        buttonShieldActive.SetActive(false);
        buttonTimeActive.SetActive(true);
        skillAudioSource.PlayOneShot(skillChooseClip);
    }
}
