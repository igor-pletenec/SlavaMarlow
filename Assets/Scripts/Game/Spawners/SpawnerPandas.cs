using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerPandas : MonoBehaviour
{
    public GameObject[] pandas;
    public GameObject player;

    Vector2 whereToSpawn;

    private float timeBtwSpawn;
    private float spawnTime;

    void Update()
    {

        if (Time.timeSinceLevelLoad <= 20.0f)
        {
            spawnTime = Random.Range(14.0f, 20.0f);
        }
        else if (Time.timeSinceLevelLoad > 20.0f && Time.timeSinceLevelLoad < 40.0f)
        {
            spawnTime = Random.Range(13.0f, 20.0f);
        }
        else if (Time.timeSinceLevelLoad > 40.0f && Time.timeSinceLevelLoad < 60.0f)
        {
            spawnTime = Random.Range(12.0f, 19.0f);
        }
        else if (Time.timeSinceLevelLoad > 60.0f && Time.timeSinceLevelLoad < 80.0f)
        {
            spawnTime = Random.Range(11.0f, 19.0f);
        }
        else if (Time.timeSinceLevelLoad > 80.0f && Time.timeSinceLevelLoad < 100.0f)
        {
            spawnTime = Random.Range(10.0f, 18.0f);
        }
        else if (Time.timeSinceLevelLoad > 100.0f && Time.timeSinceLevelLoad < 120.0f)
        {
            spawnTime = Random.Range(9.0f, 18.0f);
        }
        else if (Time.timeSinceLevelLoad > 120.0f && Time.timeSinceLevelLoad < 150.0f)
        {
            spawnTime = Random.Range(8.0f, 17.0f);
        }
        else if (Time.timeSinceLevelLoad > 150.0f && Time.timeSinceLevelLoad < 180.0f)
        {
            spawnTime = Random.Range(7.0f, 17.0f);
        }
        else if (Time.timeSinceLevelLoad > 180.0f && Time.timeSinceLevelLoad < 210.0f)
        {
            spawnTime = Random.Range(6.0f, 16.0f);
        }
        else if (Time.timeSinceLevelLoad > 210.0f && Time.timeSinceLevelLoad < 240.0f)
        {
            spawnTime = Random.Range(5.0f, 16.0f);
        }
        else if (Time.timeSinceLevelLoad > 240.0f)
        {
            spawnTime = Random.Range(4.0f, 15.0f);
        }

        if (player != null)
        {
            if (timeBtwSpawn <= 0)
            {
                int rand = Random.Range(0, pandas.Length);

                float randomPoints = Random.Range(-15f, 15f);

                whereToSpawn = new Vector2(transform.position.x, randomPoints);

                Instantiate(pandas[rand], whereToSpawn, Quaternion.identity);
                timeBtwSpawn = spawnTime;
            }
            else
            {
                timeBtwSpawn -= Time.deltaTime;
            }
        }
        else
        {
            enabled = false;
        }
    }
}
