using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public float timeOfScene;
    private int enter;

    void Start()
    {
        enter = PlayerPrefs.GetInt("Enter");
        Invoke("Play", timeOfScene);
    }

    void Play()
    {
        enter++;
        PlayerPrefs.SetInt("Enter", enter);
        PlayerPrefs.Save();

        if (PlayerPrefs.GetInt("ShoweFirst", 0) == 0)
        {
            SceneManager.LoadScene("CutScene");
            PlayerPrefs.SetFloat("VolumeMusic", -25.0f);
            PlayerPrefs.SetFloat("VolumeSounds", -20.0f);
            //PlayerPrefs.SetInt("ShoweFirst", 1); этот плеер префс меняется на кнопке пропустить и в конце кат сцены
        }
        else
        {
            SceneManager.LoadScene("Menu");
        }
    }
}
