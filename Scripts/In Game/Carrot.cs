using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carrot : MonoBehaviour
{
    int damage = 1;
    int points = 1;

    private void Start()
    {
        Destroy(gameObject, 10);
    }
    void Update()
    {
        if (GameObject.Find("GameManager").GetComponent<GM>().lives > 0)
        {
            transform.Translate(Vector2.left * GameObject.Find("GameManager").GetComponent<GM>().speed * Time.deltaTime);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("player") && GameObject.Find("GameManager").GetComponent<GM>().lives > 0)
        {
            if (GameObject.Find("GameManager").GetComponent<GM>().isCat)
            {
                // PERDER VIDA
                GameObject.Find("GameManager").GetComponent<GM>().lives -= damage;
            }
            else
            {
                // FAZER PONTO
                GameObject.Find("GameManager").GetComponent<GM>().levelScore += points;

                GameObject.Find("Spawner").GetComponent<FoodSpawn>().ReduceSpawnTime();

                GameObject.Find("GameManager").GetComponent<GM>().speed += 0.25f;


            }
            Destroy(gameObject);
        }
    }
}
