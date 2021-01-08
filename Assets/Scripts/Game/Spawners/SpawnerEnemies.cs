using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerEnemies : MonoBehaviour
{
    public GameObject[] enemies;
    public GameObject player;

    Vector2 whereToSpawn; 

    private float timeBtwSpawn;
    private float spawnTime;

    public float timeDecrease;
    private int quantityEnemies;

    void Update()
    {

        if (Time.timeSinceLevelLoad <= 20.0f)
        {
            spawnTime = 2.0f * timeDecrease;
            quantityEnemies = 1;
        }
        else if (Time.timeSinceLevelLoad > 20.0f && Time.timeSinceLevelLoad < 40.0f)
        {
            spawnTime = 1.8f * timeDecrease;
            quantityEnemies = 2;
        }
        else if (Time.timeSinceLevelLoad > 40.0f && Time.timeSinceLevelLoad < 60.0f)
        {
            spawnTime = 1.6f * timeDecrease;
            quantityEnemies = 3;
        }
        else if (Time.timeSinceLevelLoad > 60.0f && Time.timeSinceLevelLoad < 80.0f)
        {
            spawnTime = 1.4f * timeDecrease;
            quantityEnemies = 4;
        }
        else if (Time.timeSinceLevelLoad > 80.0f && Time.timeSinceLevelLoad < 100.0f)
        {
            spawnTime = 1.2f * timeDecrease;
            quantityEnemies = 5;
        }
        else if (Time.timeSinceLevelLoad > 100.0f && Time.timeSinceLevelLoad < 120.0f)
        {
            spawnTime = 1.0f * timeDecrease;
            quantityEnemies = 5;
        }
        else if (Time.timeSinceLevelLoad > 120.0f && Time.timeSinceLevelLoad < 150.0f)
        {
            spawnTime = 0.8f * timeDecrease;
            quantityEnemies = 5;
        }
        else if (Time.timeSinceLevelLoad > 150.0f && Time.timeSinceLevelLoad < 180.0f)
        {
            spawnTime = 0.6f * timeDecrease;
            quantityEnemies = 5;
        }
        else if (Time.timeSinceLevelLoad > 180.0f && Time.timeSinceLevelLoad < 210.0f)
        {
            spawnTime = 0.5f * timeDecrease;
            quantityEnemies = 5;
        }
        else if (Time.timeSinceLevelLoad > 210.0f && Time.timeSinceLevelLoad < 240.0f)
        {
            spawnTime = 0.4f * timeDecrease;
            quantityEnemies = 5;
        }
        else if (Time.timeSinceLevelLoad > 240.0f && Time.timeSinceLevelLoad < 270.0f)
        {
            spawnTime = 0.3f * timeDecrease;
            quantityEnemies = 5;
        }
        else if (Time.timeSinceLevelLoad > 270.0f && Time.timeSinceLevelLoad < 300.0f)
        {
            spawnTime = 0.25f * timeDecrease;
            quantityEnemies = 5;
        }
        else if (Time.timeSinceLevelLoad > 300.0f && Time.timeSinceLevelLoad < 330.0f)
        {
            spawnTime = 0.2f * timeDecrease;
            quantityEnemies = 5;
        }
        else if (Time.timeSinceLevelLoad > 330.0f && Time.timeSinceLevelLoad < 360.0f)
        {
            spawnTime = 0.15f * timeDecrease;
            quantityEnemies = 5;
        }
        else if (Time.timeSinceLevelLoad > 360.0f && Time.timeSinceLevelLoad < 390.0f)
        {
            spawnTime = 0.1f * timeDecrease;
            quantityEnemies = 5;
        }
        else if (Time.timeSinceLevelLoad > 390.0f && Time.timeSinceLevelLoad < 420.0f)
        {
            spawnTime = 0.09f * timeDecrease;
            quantityEnemies = 5;
        }
        else if (Time.timeSinceLevelLoad > 420.0f && Time.timeSinceLevelLoad < 450.0f)
        {
            spawnTime = 0.08f * timeDecrease;
            quantityEnemies = 5;
        }
        else if (Time.timeSinceLevelLoad > 450.0f && Time.timeSinceLevelLoad < 490.0f)
        {
            spawnTime = 0.07f * timeDecrease;
            quantityEnemies = 5;
        }
        else if (Time.timeSinceLevelLoad > 490.0f && Time.timeSinceLevelLoad < 520.0f)
        {
            spawnTime = 0.06f * timeDecrease;
            quantityEnemies = 5;
        }
        else if (Time.timeSinceLevelLoad > 520.0f)
        {
            spawnTime = 0.03f * timeDecrease;
            quantityEnemies = 5;
        }

        if (player != null)
        {
            if (timeBtwSpawn <= 0)
            {
                int rand = Random.Range(0, quantityEnemies);

                float randomPoints = Random.Range(-15f, 15f);

                whereToSpawn = new Vector2(transform.position.x, randomPoints);

                Instantiate(enemies[rand], whereToSpawn, Quaternion.identity);
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
