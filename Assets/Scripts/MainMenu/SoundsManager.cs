using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundsManager : MonoBehaviour
{
    public AudioSource managerAudioSource;
    public AudioClip buttonSound;
    public AudioClip backSound;
    public AudioClip instagramSound;

    public void ClickButtons()
    {
        managerAudioSource.PlayOneShot(buttonSound);
    }

    public void ClickBack()
    {
        managerAudioSource.PlayOneShot(backSound);
    }

    public void ClickInstagram()
    {
        managerAudioSource.PlayOneShot(instagramSound);
    }
}
