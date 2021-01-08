using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CutScene : MonoBehaviour
{
    private string text;

    public Text textIgor;

    public Animator IgorAnimator;
    public Animator SceneChangeAnimator;

    public Button button1;
    public Button button2;
    public Button button3;
    public Button button4;
    public Button button5;
    public Button button6;
    public Button button7;
    public Button button8;
    public Button button9;
    public Button button10;
    public Button button11;
    public Button button12;
    public Button button13;
    public Button button14;
    public Button button15;
    public Button buttonSkip;

    public void Start()
    {
        IgorAnimator.SetTrigger("start");
        text = "Привет!";
        StartCoroutine("PlayText");
    }

    IEnumerator PlayText()
    {
        yield return StartCoroutine(WaitForSecond());
        foreach (char c in text)
        {
            textIgor.text += c;
            yield return new WaitForSeconds(0.08f);
        }
        button1.gameObject.SetActive(true);
    }

    IEnumerator WaitForSecond()
    {
        yield return new WaitForSeconds(2.5f);
    }



    public void Button1()
    {
        textIgor.text = "";
        button1.gameObject.SetActive(false);
        text = "Ого! Откуда ты знаешь, как меня зовут?";
        StartCoroutine("PlayNextText1");
        IgorAnimator.SetTrigger("trigger01");
    }

    IEnumerator PlayNextText1()
    {
        foreach (char c in text)
        {
            textIgor.text += c;
            yield return new WaitForSeconds(0.04f);
        }
        button2.gameObject.SetActive(true);
    }



    public void Button2()
    {
        textIgor.text = "";
        button2.gameObject.SetActive(false);
        text = "Неплохо)) Сейчас я немного расскажу тебе, что это за мир и для чего ты здесь.";
        StartCoroutine("PlayNextText2");
        IgorAnimator.SetTrigger("trigger02");
    }

    IEnumerator PlayNextText2()
    {
        foreach (char c in text)
        {
            textIgor.text += c;
            yield return new WaitForSeconds(0.04f);
        }
        button3.gameObject.SetActive(true);
    }



    public void Button3()
    {
        textIgor.text = "";
        button3.gameObject.SetActive(false);
        text = "Если же ты здесь не впервые – можешь пропустить наш захватывающий диалог.";
        StartCoroutine("PlayNextText3");
        IgorAnimator.SetTrigger("trigger03");
    }

    IEnumerator PlayNextText3()
    {
        foreach (char c in text)
        {
            textIgor.text += c;
            yield return new WaitForSeconds(0.04f);
        }
        button4.gameObject.SetActive(true);
        buttonSkip.gameObject.SetActive(true);
    }



    public void ButtonSkip()
    {
        PlayerPrefs.SetInt("ShoweFirst", 1);
        PlayerPrefs.Save();
        StartCoroutine(LoadScene());
    }

    IEnumerator LoadScene()
    {
        SceneChangeAnimator.SetTrigger("end");
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene("Menu");
    }



    public void Button4()
    {
        textIgor.text = "";
        button4.gameObject.SetActive(false);
        text = "Ну тогда слушай. Мир, в который тебе предстоит окунуться – это фантазия, что находится на грани с реальностью.";
        StartCoroutine("PlayNextText4");
        IgorAnimator.SetTrigger("trigger04");
    }

    IEnumerator PlayNextText4()
    {
        foreach (char c in text)
        {
            textIgor.text += c;
            yield return new WaitForSeconds(0.04f);
        }
        button5.gameObject.SetActive(true);
    }



    public void Button5()
    {
        IgorAnimator.SetTrigger("trigger1");
        textIgor.text = "";
        button5.gameObject.SetActive(false);
        text = "Из-за сбитого графика наш главный герой столкнулся с бессонницей, которая длится уже пятый день.";
        StartCoroutine("PlayNextText5");
    }

    IEnumerator PlayNextText5()
    {
        foreach (char c in text)
        {
            textIgor.text += c;
            yield return new WaitForSeconds(0.04f);
        }
        button6.gameObject.SetActive(true);
    }



    public void Button6()
    {
        IgorAnimator.SetTrigger("trigger2");
        textIgor.text = "";
        button6.gameObject.SetActive(false);
        text = "И чтобы уснуть он решается на медитацию...";
        StartCoroutine("PlayNextText6");
    }

    IEnumerator PlayNextText6()
    {
        foreach (char c in text)
        {
            textIgor.text += c;
            yield return new WaitForSeconds(0.04f);
        }
        button7.gameObject.SetActive(true);
    }



    public void Button7()
    {
        IgorAnimator.SetTrigger("trigger3");
        textIgor.text = "";
        button7.gameObject.SetActive(false);
        text = "Твоя задача - продержаться как можно дольше и не дать этим врагам прикоснуться к главному герою.";
        StartCoroutine("PlayNextText7");
    }

    IEnumerator PlayNextText7()
    {
        foreach (char c in text)
        {
            textIgor.text += c;
            yield return new WaitForSeconds(0.04f);
        }
        button8.gameObject.SetActive(true);
    }


    public void Button8()
    {
        IgorAnimator.SetTrigger("trigger4");
        textIgor.text = "";
        button8.gameObject.SetActive(false);
        text = "Уничтожить врага ты можешь хорошенько ударив его пальцем. ";
        StartCoroutine("PlayNextText8");
    }

    IEnumerator PlayNextText8()
    {
        foreach (char c in text)
        {
            textIgor.text += c;
            yield return new WaitForSeconds(0.04f);
        }
        button9.gameObject.SetActive(true);
    }



    public void Button9()
    {
        IgorAnimator.SetTrigger("trigger5");
        textIgor.text = "";
        button9.gameObject.SetActive(false);
        text = "Помогать тебе с этим будут твои друзья – «гуру» гармонии. Но будь осторожен - к ним нельзя дотрагиваться.";
        StartCoroutine("PlayNextText9");
    }

    IEnumerator PlayNextText9()
    {
        foreach (char c in text)
        {
            textIgor.text += c;
            yield return new WaitForSeconds(0.04f);
        }
        button10.gameObject.SetActive(true);
    }



    public void Button10()
    {
        IgorAnimator.SetTrigger("trigger6");
        textIgor.text = "";
        button10.gameObject.SetActive(false);
        text = "Но, чтобы они смогли это сделать – нужно открыть и прокачать как можно сильнее твои умения.";
        StartCoroutine("PlayNextText10");
    }

    IEnumerator PlayNextText10()
    {
        foreach (char c in text)
        {
            textIgor.text += c;
            yield return new WaitForSeconds(0.04f);
        }
        button11.gameObject.SetActive(true);
    }



    public void Button11()
    {
        IgorAnimator.SetTrigger("trigger7");
        textIgor.text = "";
        button11.gameObject.SetActive(false);
        text = "Найти ты их сможешь в меню умений, оно выглядит вот так.";
        StartCoroutine("PlayNextText11");
    }

    IEnumerator PlayNextText11()
    {
        foreach (char c in text)
        {
            textIgor.text += c;
            yield return new WaitForSeconds(0.04f);
        }
        button12.gameObject.SetActive(true);
    }



    public void Button12()
    {
        IgorAnimator.SetTrigger("trigger8");
        textIgor.text = "";
        button12.gameObject.SetActive(false);
        text = "Умения открываются и прокачиваются за звезды, чтобы их заработать – выполняй различные задания в меню наград.";
        StartCoroutine("PlayNextText12");
    }

    IEnumerator PlayNextText12()
    {
        foreach (char c in text)
        {
            textIgor.text += c;
            yield return new WaitForSeconds(0.04f);
        }
        button13.gameObject.SetActive(true);
    }



    public void Button13() 
    {
        IgorAnimator.SetTrigger("trigger9");
        textIgor.text = "";
        button13.gameObject.SetActive(false);
        text = "Ну что, не очень сложно?";
        StartCoroutine("PlayNextText13");
    }

    IEnumerator PlayNextText13()
    {
        foreach (char c in text)
        {
            textIgor.text += c;
            yield return new WaitForSeconds(0.04f);
        }
        button14.gameObject.SetActive(true);
    }



    public void Button14() 
    {
        textIgor.text = "";
        button14.gameObject.SetActive(false);
        text = "Удачи!";
        StartCoroutine("PlayNextText14");
        IgorAnimator.SetTrigger("trigger10");
    }

    IEnumerator PlayNextText14()
    {
        foreach (char c in text)
        {
            textIgor.text += c;
            yield return new WaitForSeconds(0.04f);
        }
        button15.gameObject.SetActive(true);
    }
}
