using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathMenu : MonoBehaviour
{
    public Animator sceneChange;
    public AudioSource deathAudioSource;
    public AudioClip doorClip;
    public AudioClip exitClip;

    public void Restart()
    {
        PlayerPrefs.Save();
        StartCoroutine(ReLoadScene());
        deathAudioSource.PlayOneShot(doorClip);
    }

    public void Home()
    {
        PlayerPrefs.Save();
        StartCoroutine(LoadScene());
        deathAudioSource.PlayOneShot(doorClip);

    }

    public void QuitGame()
    {
        deathAudioSource.PlayOneShot(exitClip);
        PlayerPrefs.Save();
        Application.Quit();
    }

    IEnumerator LoadScene()
    {
        sceneChange.SetTrigger("end");
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("Menu");
    }

    IEnumerator ReLoadScene()
    {
        sceneChange.SetTrigger("end");
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
