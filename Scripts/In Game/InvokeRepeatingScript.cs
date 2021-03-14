using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvokeRepeatingScript : MonoBehaviour
{
    public int isCarrot;

    public GameObject carrot;
    public GameObject fish;

    void Start()
    {
        InvokeRepeating("Repeat", 0f, 1f);
        InvokeRepeating("Repeat", 1f, 1.89f);;
    }
    private void Update()
    {
        isCarrot = Random.Range(0, 2);
    }
    public void Repeat()
    {
        Spawn();
    }
    public void Spawn()
    {
        if (GameObject.Find("GameManager").GetComponent<GM>().lives > 0)
        {
            if (isCarrot == 1)
            {
                Vector3 randomPosCarrot = new Vector3(transform.position.x, Random.Range(-4f, 4f), 0);
                Instantiate(carrot, randomPosCarrot, Quaternion.identity);
            }
            else
            {
                Vector3 randomPosFish = new Vector3(transform.position.x, Random.Range(-4f, 4f), 0);
                Instantiate(fish, randomPosFish, Quaternion.identity);
            }
        }
    }

}
