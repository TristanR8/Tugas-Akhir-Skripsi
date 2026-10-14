using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float playerMoveSpeed = 0f;
    void Update()
    {   
        //Move Left Button
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left * playerMoveSpeed * Time.deltaTime;
            Debug.Log("Left");
        }
       
        //Move Right Button
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right * playerMoveSpeed * Time.deltaTime;
            Debug.Log("Right");
        }
        
        
    }
}
