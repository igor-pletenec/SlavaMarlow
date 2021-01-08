using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pandas : MonoBehaviour
{
    public int quantityPandas; //кол-во панд в начале раунда 0
    public int numOfPandas; // кол-во панд

    public Image[] pandas;
    public Sprite fullPanda;
    public Sprite emptyPanda;

    public GameObject skillLockDisable;
    public GameObject buttonAttackDisable;
    public GameObject buttonShieldDisable;
    public GameObject buttonTimeDisable;

    public GameObject skillLock;
    public GameObject buttonAttack;
    public GameObject buttonShield;
    public GameObject buttonTime;

    public GameObject PandaScript;

    private int checkSkill;

    private void Start()
    {
        checkSkill = PlayerPrefs.GetInt("SkillChoose");

        if (checkSkill == 0)
        {
            skillLockDisable.SetActive(true);
            buttonAttackDisable.SetActive(false);
            buttonShieldDisable.SetActive(false);
            buttonTimeDisable.SetActive(false);
        }

        if (checkSkill == 1)
        {
            skillLockDisable.SetActive(false);
            buttonAttackDisable.SetActive(true);
            buttonShieldDisable.SetActive(false);
            buttonTimeDisable.SetActive(false);
        }

        if (checkSkill == 2)
        {
            skillLockDisable.SetActive(false);
            buttonAttackDisable.SetActive(false);
            buttonShieldDisable.SetActive(true);
            buttonTimeDisable.SetActive(false);
        }

        if (checkSkill == 3)
        {
            skillLockDisable.SetActive(false);
            buttonAttackDisable.SetActive(false);
            buttonShieldDisable.SetActive(false);
            buttonTimeDisable.SetActive(true);
        }
    }

    void Update()
    {
        if (quantityPandas == 6 && checkSkill == 0)
        {
            skillLockDisable.SetActive(false);
            skillLock.SetActive(true);
        }

        if (quantityPandas == 6 && checkSkill == 1)
        {
            buttonAttackDisable.SetActive(false);
            buttonAttack.SetActive(true);
        }

        if (quantityPandas == 6 && checkSkill == 2)
        {
            buttonShieldDisable.SetActive(false);
            buttonShield.SetActive(true);
        }

        if (quantityPandas == 6 && checkSkill == 3)
        {
            buttonTimeDisable.SetActive(false);
            buttonTime.SetActive(true);
        }

        if (quantityPandas > numOfPandas)
        {
            quantityPandas = numOfPandas;
        }

        for (int i = 0; i < pandas.Length; i++)
        {
            if (i < quantityPandas)
            {
                pandas[i].sprite = fullPanda;
            }
            else
            {
                pandas[i].sprite = emptyPanda;
            }

            if (i < numOfPandas)
            {
                pandas[i].enabled = true;
            }
            else
            {
                pandas[i].enabled = false;
            }
        }
    }

    public void AttackSkill()
    {
        PandaScript.GetComponent<Pandas>().quantityPandas = 0;
        buttonAttackDisable.SetActive(true);
        buttonAttack.SetActive(false);
    }

    public void ShieldSkill()
    {
        PandaScript.GetComponent<Pandas>().quantityPandas = 0;
        buttonShieldDisable.SetActive(true);
        buttonShield.SetActive(false);
    }

    public void TimeSkill()
    {
        PandaScript.GetComponent<Pandas>().quantityPandas = 0;
        buttonTimeDisable.SetActive(true);
        buttonTime.SetActive(false);
    }
}
