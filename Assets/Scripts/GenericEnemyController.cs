using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericEnemyController : MonoBehaviour
{
    public float speed = 10.0f;

    void Start()
    {
        
    }

    // moves down the screen until destroyed or it hits the bottom of the map
    void Update()
    {
        transform.Translate(speed * Time.deltaTime * -Vector3.forward);
        if (transform.position.z < GlobalVariables.bottom)
        {
            Destroy(gameObject);
        }
    }
}
