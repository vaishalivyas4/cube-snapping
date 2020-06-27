using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSnap : MonoBehaviour
{
    int movement = 3;
  
    void Update()
    {
        hMovement();
    }

    void hMovement()
    {
        if(Input.GetKeyDown(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-movement, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(movement, 0, 0);
        }

        movement = Mathf.Clamp(movement, -3, 3);
    }
}
