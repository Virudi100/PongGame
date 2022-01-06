using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{
    public float speed = 5f;

    // Update is called once per frame

    private void FixedUpdate()
    {
        IsInput();
    }

    void IsInput()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            //this.transform.position = Vector3.forward;
            Vector3 translation = Vector3.up * speed * Time.deltaTime;
            transform.Translate(translation);
            Debug.Log("up arrow is pressed");
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            //this.transform.position = Vector3.forward;
            Vector3 translation = Vector3.down * speed * Time.deltaTime;
            transform.Translate(translation);
            Debug.Log("down arrow is pressed");
        }
    }
}
