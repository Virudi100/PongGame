using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 3;

    private void Start()
    {
        Launch();
    }

    private void Launch()
    {
        //float x = Random.Range(0, 2) == 0 ? -1 : 1;

        float x = Random.Range(0, 2);
        if (x == 0)
        {
            x = -1;
        }
        else x = 1;

        //float y = Random.Range(0, 2) == 0 ? -1 : 1;

        float y = Random.Range(0, 2);
        if(y == 0)
        {
            y = -1;
        }
        else y = 1; 


        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(speed * x, speed * y);

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            speed += 0.5f;
            Launch();
            
        }
    }
}
