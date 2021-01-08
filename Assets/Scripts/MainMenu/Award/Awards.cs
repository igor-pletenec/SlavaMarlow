using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Awards : MonoBehaviour
{
    public ButtonPointer button0;
    public ButtonPointer button1;
    public ButtonPointer button2;
    public ButtonPointer button3;
    public ButtonPointer button4;
    public ButtonPointer button5;
    public ButtonPointer button6;

    public GameObject helpPanell;
    public Text helpValue;
    public string helpText;

    public GameObject award0;
    public GameObject award1;
    public GameObject award2;
    public GameObject award3;
    public GameObject award4;
    public GameObject award5;
    public GameObject award6;

    public GameObject Skill;

    public GameObject particleCircle;
    public GameObject particleStar;

    [SerializeField] int awardValue;
    [SerializeField] int awardLevel;

    public string awardName;
    public string awardLevelName;

    public int value1;
    public int value2;
    public int value3;
    public int value4;
    public int value5;
    public int value6;

    public AudioClip openAward;
    public AudioSource awardAudioSource;

    private void Start()
    {
        awardLevel = PlayerPrefs.GetInt(awardLevelName);

        if (awardLevel == 0)
        {
            award0.gameObject.SetActive(true);
            award1.gameObject.SetActive(false);
            award2.gameObject.SetActive(false);
            award3.gameObject.SetActive(false);
            award4.gameObject.SetActive(false);
            award5.gameObject.SetActive(false);
            award6.gameObject.SetActive(false);
        }

        if (awardLevel == 1)
        {
            award0.gameObject.SetActive(false);
            award1.gameObject.SetActive(true);
            award2.gameObject.SetActive(false);
            award3.gameObject.SetActive(false);
            award4.gameObject.SetActive(false);
            award5.gameObject.SetActive(false);
            award6.gameObject.SetActive(false);
        }

        if (awardLevel == 2)
        {
            award0.gameObject.SetActive(false);
            award1.gameObject.SetActive(false);
            award2.gameObject.SetActive(true);
            award3.gameObject.SetActive(false);
            award4.gameObject.SetActive(false);
            award5.gameObject.SetActive(false);
            award6.gameObject.SetActive(false);
        }

        if (awardLevel == 3)
        {
            award0.gameObject.SetActive(false);
            award1.gameObject.SetActive(false);
            award2.gameObject.SetActive(false);
            award3.gameObject.SetActive(true);
            award4.gameObject.SetActive(false);
            award5.gameObject.SetActive(false);
            award6.gameObject.SetActive(false);
        }

        if (awardLevel == 4)
        {
            award0.gameObject.SetActive(false);
            award1.gameObject.SetActive(false);
            award2.gameObject.SetActive(false);
            award3.gameObject.SetActive(false);
            award4.gameObject.SetActive(true);
            award5.gameObject.SetActive(false);
            award6.gameObject.SetActive(false);
        }

        if (awardLevel == 5)
        {
            award0.gameObject.SetActive(false);
            award1.gameObject.SetActive(false);
            award2.gameObject.SetActive(false);
            award3.gameObject.SetActive(false);
            award4.gameObject.SetActive(false);
            award5.gameObject.SetActive(true);
            award6.gameObject.SetActive(false);
        }

        if (awardLevel == 6)
        {
            award0.gameObject.SetActive(false);
            award1.gameObject.SetActive(false);
            award2.gameObject.SetActive(false);
            award3.gameObject.SetActive(false);
            award4.gameObject.SetActive(false);
            award5.gameObject.SetActive(false);
            award6.gameObject.SetActive(true);
        }
    }

    public void Update()
    {
        awardValue = PlayerPrefs.GetInt(awardName);
        awardLevel = PlayerPrefs.GetInt(awardLevelName);

        if (awardValue >= value1 && awardLevel == 0)
        {
            particleCircle.gameObject.SetActive(true);
        }
        else if (awardValue < value1 && awardLevel == 0)
        {
            award0.gameObject.SetActive(true);

            if (button0.isDown)
            {
                helpPanell.gameObject.SetActive(true);
                helpValue.text = helpText + awardValue.ToString() + "/" + value1.ToString();
            }
            else
            {
                helpPanell.gameObject.SetActive(false);
            }
        }

        if (awardValue >= value2 && awardLevel == 1)
        {
            particleCircle.gameObject.SetActive(true);
        }
        else if (awardValue < value2 && awardLevel == 1)
        {
            award1.gameObject.SetActive(true);

            if (button1.isDown)
            {
                helpPanell.gameObject.SetActive(true);
                helpValue.text = helpText + awardValue.ToString() + "/" + value2.ToString();
            }
            else
            {
                helpPanell.gameObject.SetActive(false);
            }
        }

        if (awardValue >= value3 && awardLevel == 2)
        {
            particleCircle.gameObject.SetActive(true);
        }
        else if (awardValue < value3 && awardLevel == 2)
        {
            award2.gameObject.SetActive(true);

            if (button2.isDown)
            {
                helpPanell.gameObject.SetActive(true);
                helpValue.text = helpText + awardValue.ToString() + "/" + value3.ToString();
            }
            else
            {
                helpPanell.gameObject.SetActive(false);
            }
        }

        if (awardValue >= value4 && awardLevel == 3)
        {
            particleCircle.gameObject.SetActive(true);
        }
        else if (awardValue < value4 && awardLevel == 3)
        {
            award3.gameObject.SetActive(true);

            if (button3.isDown)
            {
                helpPanell.gameObject.SetActive(true);
                helpValue.text = helpText + awardValue.ToString() + "/" + value4.ToString();
            }
            else
            {
                helpPanell.gameObject.SetActive(false);
            }
        }

        if (awardValue >= value5 && awardLevel == 4)
        {
            particleCircle.gameObject.SetActive(true);
        }
        else if (awardValue < value5 && awardLevel == 4)
        {
            award4.gameObject.SetActive(true);

            if (button4.isDown)
            {
                helpPanell.gameObject.SetActive(true);
                helpValue.text = helpText + awardValue.ToString() + "/" + value5.ToString();
            }
            else
            {
                helpPanell.gameObject.SetActive(false);
            }
        }

        if (awardValue >= value6 && awardLevel == 5)
        {
            particleCircle.gameObject.SetActive(true);
        }
        else if (awardValue < value6 && awardLevel == 5)
        {
            award5.gameObject.SetActive(true);

            if (button5.isDown)
            {
                helpPanell.gameObject.SetActive(true);
                helpValue.text = helpText + awardValue.ToString() + "/" + value6.ToString();
            }
            else
            {
                helpPanell.gameObject.SetActive(false);
            }
        }

        if (awardLevel == 6)
        {
            award6.gameObject.SetActive(true);

            if (button6.isDown)
            {
                helpPanell.gameObject.SetActive(true);
                helpValue.text = "Это максимум. Мое почтение ;)";
            }
            else
            {
                helpPanell.gameObject.SetActive(false);
            }
        }
    }

    public void awardButton0()
    {
        if (awardValue >= value1)
        {
            Destroy(award0);
            award1.gameObject.SetActive(true);
            particleStar.gameObject.SetActive(true);
            particleCircle.gameObject.SetActive(false);
            PlayerPrefs.SetInt(awardLevelName, 1);
            Invoke("StopParticleSystem", 1);
            Skill.GetComponent<SkillStars>().starsInt++;
            awardAudioSource.PlayOneShot(openAward);
        }
    }

    public void awardButton1()
    {
        if (awardValue >= value2)
        {
            Destroy(award1);
            award2.gameObject.SetActive(true);
            particleStar.gameObject.SetActive(true);
            particleCircle.gameObject.SetActive(false);
            PlayerPrefs.SetInt(awardLevelName, 2);
            Invoke("StopParticleSystem", 1);
            Skill.GetComponent<SkillStars>().starsInt++;
            awardAudioSource.PlayOneShot(openAward);
        }
    }

    public void awardButton2()
    {
        if (awardValue >= value3)
        {
            Destroy(award2);
            award3.gameObject.SetActive(true);
            particleStar.gameObject.SetActive(true);
            particleCircle.gameObject.SetActive(false);
            PlayerPrefs.SetInt(awardLevelName, 3);
            Invoke("StopParticleSystem", 1);
            Skill.GetComponent<SkillStars>().starsInt++;
            awardAudioSource.PlayOneShot(openAward);
        }
    }

    public void awardButton3()
    {
        if (awardValue >= value4)
        {
            Destroy(award3);
            award4.gameObject.SetActive(true);
            particleStar.gameObject.SetActive(true);
            particleCircle.gameObject.SetActive(false);
            PlayerPrefs.SetInt(awardLevelName, 4);
            Invoke("StopParticleSystem", 1);
            Skill.GetComponent<SkillStars>().starsInt++;
            awardAudioSource.PlayOneShot(openAward);
        }
    }

    public void awardButton4()
    {
        if (awardValue >= value5)
        {
            Destroy(award4);
            award5.gameObject.SetActive(true);
            particleStar.gameObject.SetActive(true);
            particleCircle.gameObject.SetActive(false);
            PlayerPrefs.SetInt(awardLevelName, 5);
            Invoke("StopParticleSystem", 1);
            Skill.GetComponent<SkillStars>().starsInt++;
            awardAudioSource.PlayOneShot(openAward);
        }
    }

    public void awardButton5()
    {
        if (awardValue >= value6)
        {
            Destroy(award5);
            award6.gameObject.SetActive(true);
            particleStar.gameObject.SetActive(true);
            particleCircle.gameObject.SetActive(false);
            PlayerPrefs.SetInt(awardLevelName, 6);
            Invoke("StopParticleSystem", 1);
            Skill.GetComponent<SkillStars>().starsInt++;
            awardAudioSource.PlayOneShot(openAward);
        }
    }

    public void awardButton6()
    {
        if (awardValue >= value6)
        {
            // вылазит текст что достигнут максимум
        }
    }

    public void StopParticleSystem()
    {
        particleStar.gameObject.SetActive(false);
    }
}
