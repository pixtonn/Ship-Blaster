using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;

    void Start()
    {
        
    }

    void Update()
    {
        float xAxis = Input.GetAxis("Horizontal");
        float yAxis = Input.GetAxis("Vertical");

        if (xAxis != 0 || yAxis != 0)
        {
            transform.Translate(speed * Time.deltaTime * xAxis * Vector3.right);
            transform.Translate(speed * Time.deltaTime * yAxis * Vector3.forward);
            
            // now check if out of bounds, and move back in if the player is out
            if (transform.position.x < -GlobalVariables.leftRight || transform.position.x > GlobalVariables.leftRight)
            {
                transform.Translate(speed * Time.deltaTime * xAxis * -Vector3.right);
            }
            if (transform.position.z > GlobalVariables.top || transform.position.z < GlobalVariables.bottom)
            {
                transform.Translate(speed * Time.deltaTime * yAxis * -Vector3.forward);
            }
        }
    }
}
