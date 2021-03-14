using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public Joystick joystick;
    public float speed;
    Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (GameObject.Find("GameManager").GetComponent<GM>().lives > 0)
        {
            float xMov = joystick.Horizontal;
            float yMov = joystick.Vertical;
            rb.velocity = new Vector3(xMov, yMov) * speed;

        }
    }
}
