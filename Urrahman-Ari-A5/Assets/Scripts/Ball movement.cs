using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ballmovement : MonoBehaviour
{
    Rigidbody2D rb;
    public float Ballmove = 10;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(Ballmove, Ballmove);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
