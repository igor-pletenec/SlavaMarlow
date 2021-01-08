using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public int health;
    public int numOfHearts;

    public Image[] hearts;
    public Sprite fullHearts;
    public Sprite emptyHearts;

    public GameObject deathMenu;
    public GameObject scoreText;

    public GameObject damage1;
    public GameObject damage2;

    public Animator heartsAnimator1;
    public Animator heartsAnimator2;
    public Animator heartsAnimator3;

    public AudioSource mainCameraAudioSource;

    public GameObject playerImage1;
    public GameObject playerImage2;

    public AudioSource skillShieldSource;
    public AudioSource skillTimeSource;
    public AudioSource playerSource;
    public AudioClip hitPlayer;
    public AudioClip pandaPlus;

    void Update()
    {
        if (Time.timeSinceLevelLoad < 4.0f)
        {
            playerImage1.SetActive(true);
            playerImage2.SetActive(false);
        }
        else if (Time.timeSinceLevelLoad >= 4.0f)
        {
            playerImage1.SetActive(false);
            playerImage2.SetActive(true);
        }

        if (health == 2)
        {
            heartsAnimator3.SetTrigger("minus");
            damage1.SetActive(true);
        }

        if (health == 1)
        {
            heartsAnimator2.SetTrigger("minus");
            damage2.SetActive(true);
        }

        if (health <= 0)
        {
            heartsAnimator1.SetTrigger("minus");
            scoreText.SetActive(false);
            deathMenu.SetActive(true);
            mainCameraAudioSource.Pause();
            skillShieldSource.Pause();
            skillTimeSource.Pause();
            Destroy(gameObject);
        }

        if (health > numOfHearts)
        {
            health = numOfHearts;
        }

        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < health)
            {
                hearts[i].sprite = fullHearts;
            }
            else
            {
                hearts[i].sprite = emptyHearts;
            }


            if (i < numOfHearts)
            {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            health--;
            playerSource.PlayOneShot(hitPlayer);
        }

        if (other.CompareTag("Panda"))
        {
            playerSource.PlayOneShot(pandaPlus);
        }
    }
}
