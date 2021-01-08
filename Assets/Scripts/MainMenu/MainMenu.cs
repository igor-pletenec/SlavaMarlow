using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public Animator sceneChange;

    public void PlayGame()
    {
        PlayerPrefs.Save();
        StartCoroutine(LoadScene());
    }

    public void QuitGame()
    {
        PlayerPrefs.Save();
        Application.Quit();
    }

    IEnumerator LoadScene()
    {
        sceneChange.SetTrigger("end");
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene("Game");
    }
}
