using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecretManager : MonoBehaviour
{
    public AudioSource audioSourceMainCamera;
    public AudioSource secretAudioSource;
    public AudioClip secretClip;
    public AudioClip secretClip2;

    public void PlaySecret()
    {
        audioSourceMainCamera.Pause();
        secretAudioSource.PlayOneShot(secretClip);
        Invoke("EndOfMusic", 18);
    }

    public void PlaySecret2()
    {
        audioSourceMainCamera.Pause();
        secretAudioSource.PlayOneShot(secretClip2);
        Invoke("EndOfMusic", 8);
    }

    void EndOfMusic()
    {
        audioSourceMainCamera.UnPause();
    }

}
