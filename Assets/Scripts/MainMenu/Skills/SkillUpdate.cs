using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillUpdate : MonoBehaviour
{
    public int price;
    public int lastPrice;
    public int stars;
    public int skillLevel;

    public string nameOfSkill;
    public string helptext;

    public Text priceOfSkill;
    public Text helpText;

    public GameObject Skill0;
    public GameObject Skill1;
    public GameObject Skill2;
    public GameObject Skill3;
    public GameObject Skill4;
    public GameObject Skill5;
    public GameObject Skill6;
    public GameObject Skill7;
    public GameObject Skill8;
    public GameObject Skill9;
    public GameObject Skill10;

    public ButtonPointer button0;
    public ButtonPointer button1;
    public ButtonPointer button2;
    public ButtonPointer button3;
    public ButtonPointer button4;
    public ButtonPointer button5;
    public ButtonPointer button6;
    public ButtonPointer button7;
    public ButtonPointer button8;
    public ButtonPointer button9;
    public ButtonPointer button10;

    public GameObject helpPannel;
    public GameObject buttonUpdate;
    public GameObject Skill;

    public AudioSource skillUpdateSource;
    public AudioClip skillUpdateClip;

    void FixedUpdate()
    {
        stars = PlayerPrefs.GetInt("Stars");
        skillLevel = PlayerPrefs.GetInt(nameOfSkill);
        priceOfSkill.text = "Улучшить за " + price.ToString();


        if (skillLevel == 0)
        {
            Skill0.SetActive(true);

            if (button0.isDown)
            {
                helpPannel.SetActive(true);
                helpText.text = helptext + skillLevel + "/10";
            }
            else
            {
                helpPannel.SetActive(false);
            }
        }
        else
        {
            Skill0.SetActive(false);
        }

        if (skillLevel == 1)
        {
            Skill1.SetActive(true);

            if (button1.isDown)
            {
                helpPannel.SetActive(true);
                helpText.text = helptext + skillLevel + "/10";
            }
            else
            {
                helpPannel.SetActive(false);
            }
        }
        else
        {
            Skill1.SetActive(false);
        }

        if (skillLevel == 2)
        {
            Skill2.SetActive(true);

            if (button2.isDown)
            {
                helpPannel.SetActive(true);
                helpText.text = helptext + skillLevel + "/10";
            }
            else
            {
                helpPannel.SetActive(false);
            }
        }
        else
        {
            Skill2.SetActive(false);
        }


        if (skillLevel == 3)
        {
            Skill3.SetActive(true);

            if (button3.isDown)
            {
                helpPannel.SetActive(true);
                helpText.text = helptext + skillLevel + "/10";
            }
            else
            {
                helpPannel.SetActive(false);
            }
        }
        else
        {
            Skill3.SetActive(false);
        }


        if (skillLevel == 4)
        {
            Skill4.SetActive(true);

            if (button4.isDown)
            {
                helpPannel.SetActive(true);
                helpText.text = helptext + skillLevel + "/10";
            }
            else
            {
                helpPannel.SetActive(false);
            }
        }
        else
        {
            Skill4.SetActive(false);
        }


        if (skillLevel == 5)
        {
            Skill5.SetActive(true);

            if (button5.isDown)
            {
                helpPannel.SetActive(true);
                helpText.text = helptext + skillLevel + "/10";
            }
            else
            {
                helpPannel.SetActive(false);
            }
        }
        else
        {
            Skill5.SetActive(false);
        }


        if (skillLevel == 6)
        {
            Skill6.SetActive(true);

            if (button6.isDown)
            {
                helpPannel.SetActive(true);
                helpText.text = helptext + skillLevel + "/10";
            }
            else
            {
                helpPannel.SetActive(false);
            }
        }
        else
        {
            Skill6.SetActive(false);
        }


        if (skillLevel == 7)
        {
            Skill7.SetActive(true);

            if (button7.isDown)
            {
                helpPannel.SetActive(true);
                helpText.text = helptext + skillLevel + "/10";
            }
            else
            {
                helpPannel.SetActive(false);
            }
        }
        else
        {
            Skill7.SetActive(false);
        }


        if (skillLevel == 8)
        {
            Skill8.SetActive(true);

            if (button8.isDown)
            {
                helpPannel.SetActive(true);
                helpText.text = helptext + skillLevel + "/10";
            }
            else
            {
                helpPannel.SetActive(false);
            }
        }
        else
        {
            Skill8.SetActive(false);
        }


        if (skillLevel == 9)
        {
            Skill9.SetActive(true);
            price = lastPrice;

            if (button9.isDown)
            {
                helpPannel.SetActive(true);
                helpText.text = helptext + skillLevel + "/10";
            }
            else
            {
                helpPannel.SetActive(false);
            }
        }
        else
        {
            Skill9.SetActive(false);
        }


        if (skillLevel == 10)
        {
            Skill10.SetActive(true);
            buttonUpdate.SetActive(false);

            if (button10.isDown)
            {
                helpPannel.SetActive(true);
                helpText.text = helptext + skillLevel + "/10";
            }
            else
            {
                helpPannel.SetActive(false);
            }
        }
        else
        {
            Skill10.SetActive(false);
        }

    }

    public void UpdateSkill()
    {
        if (stars >= price)
        {
            PlayerPrefs.SetInt("Stars", Skill.GetComponent<SkillStars>().starsInt -= price);
            skillLevel++;
            PlayerPrefs.SetInt(nameOfSkill, skillLevel);
            skillUpdateSource.PlayOneShot(skillUpdateClip);
        }
    }
}
