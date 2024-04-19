using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIpaddlemovement : MonoBehaviour
{
    Rigidbody2D rb;
    public float paddlespeed = 10;
    private int directions = 0;
    public GameObject ball;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (ball.transform.position.y > transform.position.y)
        {
            directions = 1;
        }
        else if (ball.transform.position.y < transform.position.y)
        {
            directions = -1;
        }

        rb.velocity = (new Vector2(0, directions * paddlespeed));
    }
}