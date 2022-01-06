using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour
{
    public float speed = 5f;

    // Update is called once per frame

    private void FixedUpdate()
    {
        IsInput();
    }
 
    void IsInput()
    {
        if(Input.GetKey(KeyCode.Z))
        {
            //this.transform.position = Vector3.forward;
            Vector3 translation = Vector3.up * speed * Time.deltaTime;
            transform.Translate(translation);
            Debug.Log("Z is pressed");
        }

        if (Input.GetKey(KeyCode.S))
        {
            //this.transform.position = Vector3.forward;
            Vector3 translation = Vector3.down * speed * Time.deltaTime;
            transform.Translate(translation);
            Debug.Log("Z is pressed");
        }
    }
}
