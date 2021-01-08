using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    public int healthEnemy;

    public GameObject deathEffect;
    public GameObject shieldEffect;
    private GameObject player;
    private Transform target;
    private Animator camShake;

    private AudioSource enemyAudioSource;
    public AudioClip hitClip;

    private float dragSpeed;

    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        player = GameObject.FindGameObjectWithTag("Player");
        camShake = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Animator>();
        enemyAudioSource = gameObject.GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Time.timeSinceLevelLoad <= 20.0f)
        {
            dragSpeed = 0;
        }
        else if (Time.timeSinceLevelLoad > 20.0f && Time.timeSinceLevelLoad < 40.0f)
        {
            dragSpeed = 0.2f;
        }
        else if (Time.timeSinceLevelLoad > 40.0f && Time.timeSinceLevelLoad < 60.0f)
        {
            dragSpeed = 0.4f;
        }
        else if (Time.timeSinceLevelLoad > 60.0f && Time.timeSinceLevelLoad < 80.0f)
        {
            dragSpeed = 0.6f;
        }
        else if (Time.timeSinceLevelLoad > 80.0f && Time.timeSinceLevelLoad < 100.0f)
        {
            dragSpeed = 0.8f;
        }
        else if (Time.timeSinceLevelLoad > 100.0f && Time.timeSinceLevelLoad < 120.0f)
        {
            dragSpeed = 1.0f;
        }
        else if (Time.timeSinceLevelLoad > 120.0f && Time.timeSinceLevelLoad < 150.0f)
        {
            dragSpeed = 1.2f;
        }
        else if (Time.timeSinceLevelLoad > 150.0f && Time.timeSinceLevelLoad < 180.0f)
        {
            dragSpeed = 1.4f;
        }
        else if (Time.timeSinceLevelLoad > 180.0f && Time.timeSinceLevelLoad < 210.0f)
        {
            dragSpeed = 1.5f;
        }
        else if (Time.timeSinceLevelLoad > 210.0f && Time.timeSinceLevelLoad < 240.0f)
        {
            dragSpeed = 1.6f;
        }
        else if (Time.timeSinceLevelLoad > 240.0f && Time.timeSinceLevelLoad < 270.0f)
        {
            dragSpeed = 1.7f;
        }
        else if (Time.timeSinceLevelLoad > 270.0f && Time.timeSinceLevelLoad < 300.0f)
        {
            dragSpeed = 1.8f;
        }
        else if (Time.timeSinceLevelLoad > 300.0f && Time.timeSinceLevelLoad < 330.0f)
        {
            dragSpeed = 1.9f;
        }
        else if (Time.timeSinceLevelLoad > 330.0f && Time.timeSinceLevelLoad < 360.0f)
        {
            dragSpeed = 2.0f;
        }
        else if (Time.timeSinceLevelLoad > 360.0f && Time.timeSinceLevelLoad < 390.0f)
        {
            dragSpeed = 2.1f;
        }
        else if (Time.timeSinceLevelLoad > 390.0f && Time.timeSinceLevelLoad < 420.0f)
        {
            dragSpeed = 2.2f;
        }
        else if (Time.timeSinceLevelLoad > 420.0f && Time.timeSinceLevelLoad < 450.0f)
        {
            dragSpeed = 2.3f;
        }
        else if (Time.timeSinceLevelLoad > 450.0f && Time.timeSinceLevelLoad < 490.0f)
        {
            dragSpeed = 2.4f;
        }
        else if (Time.timeSinceLevelLoad > 490.0f && Time.timeSinceLevelLoad < 520.0f)
        {
            dragSpeed = 2.5f;
        }
        else if (Time.timeSinceLevelLoad > 520.0f)
        {
            dragSpeed = 3.0f;
        }

        if (player != null)
        {
            int checkTime = PlayerPrefs.GetInt("SlowSpeed");

            if (checkTime == 0)
            {
                transform.position = Vector2.MoveTowards(transform.position, target.position, (speed + dragSpeed) * Time.deltaTime);
            }

            if (checkTime == 1)
            {
                transform.position = Vector2.MoveTowards(transform.position, target.position, ((speed + dragSpeed) / 2.0f) * Time.deltaTime);
            }
        }
        else
        {
            Destroy(gameObject);
            enabled = false;
        }
    }

    private void OnMouseDown()
    {
        camShake.SetTrigger("shake");
        enemyAudioSource.PlayOneShot(hitClip);
        healthEnemy--;
        if (healthEnemy <= 0)
        {
            player.GetComponent<Score>().scoreInt++;
            player.GetComponent<Score>().kills++;
            Instantiate(deathEffect, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            camShake.SetTrigger("shakeDeath");
            Destroy(gameObject);
        }

        if (other.CompareTag("Shield"))
        {
            camShake.SetTrigger("shakeDeath");
            Destroy(gameObject);
            Instantiate(shieldEffect, transform.position, Quaternion.identity);
        }

        if (other.CompareTag("Attack"))
        {
            camShake.SetTrigger("shakeDeath");
            player.GetComponent<Score>().scoreInt++;
            player.GetComponent<Score>().kills++;
            Destroy(gameObject);
            Instantiate(deathEffect, transform.position, Quaternion.identity);
        }
    }
}
