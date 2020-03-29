using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    private float speed =1f;
    private float minspeed = 2f;
    private float maxspeed = 4f;

    private Rigidbody2D rb;


     void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        speed = Random.Range(minspeed, maxspeed);
    }

    /*   private void Update()
       {
           transform.Translate(speed, 0, 0);
       }*/

    void FixedUpdate()
    {
        Vector2 forward = new Vector2(transform.right.x, transform.right.y);
        rb.MovePosition(rb.position + forward * Time.fixedDeltaTime * speed);

    }


}
