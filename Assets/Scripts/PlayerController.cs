using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 30.0f;

    void Start()
    {
        
    }

    void Update()
    {
        float xAxis = Input.GetAxis("Horizontal");
        float yAxis = Input.GetAxis("Vertical");

        if (xAxis != 0 || yAxis != 0)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * yAxis * speed);
            transform.Translate(Vector3.right * Time.deltaTime * xAxis * speed);
        }
    }
}
