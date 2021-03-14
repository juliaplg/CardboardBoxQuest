using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodSpawn : MonoBehaviour
{
    public GameObject carrot;
    public GameObject fish;

    float spawnTime = 0.9f;
    float startSpawnTime = 1.8f;

    float decreaseTime = 0.08f;
    float minTime = 0.30f;

    int randomNum;

    private void Update()
    {
        if (spawnTime <= 0)
        {
            randomNum = Random.Range(0, 2);
            if (randomNum == 0)
            {
                SpawnCarrot();
            }
            else if (randomNum == 1)
            {
                SpawnFish();
            }
            else
            {
                Debug.Log("RandomNum: " + randomNum);
            }
            

        }
        else
        {
            spawnTime -= Time.deltaTime;
        }
    }

    public void ReduceSpawnTime()
    {
        startSpawnTime = Mathf.Clamp(startSpawnTime - decreaseTime, minTime, 100000f);
        Debug.Log("StartSpawnTime" + startSpawnTime);
    }
    public void SpawnCarrot()
    {
        Vector3 randomPosFood = new Vector3(transform.position.x, Random.Range(-4f, 4f), 0);
        Instantiate(carrot, randomPosFood, Quaternion.identity);
        spawnTime = startSpawnTime;
    }
    public void SpawnFish()
    {
        Vector3 randomPosFood = new Vector3(transform.position.x, Random.Range(-4f, 4f), 0);
        Instantiate(fish, randomPosFood, Quaternion.identity);
        spawnTime = startSpawnTime;
    }

}
