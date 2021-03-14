using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarrotSpawner : MonoBehaviour
{
    public GameObject carrot;
    
    float spawnTime;
    float startSpawnTime = 1.8f;

    float decreaseTime = 0.08f;
    float minTime = 0.30f;

    private void Update()
    {
        if (spawnTime <= 0)
        {
            Vector3 randomPosCarrot = new Vector3(transform.position.x, Random.Range(-4f, 4f), 0);
            Instantiate(carrot, randomPosCarrot, Quaternion.identity);
            spawnTime = startSpawnTime;
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

}
