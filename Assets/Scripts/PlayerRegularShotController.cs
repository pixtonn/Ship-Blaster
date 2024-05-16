using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRegularShotController : MonoBehaviour
{
    public float speed = 30.0f;

    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(speed * Time.deltaTime * Vector3.forward, Space.World);

        // destroy itself if out of bounds
        if (transform.position.z > GlobalVariables.top+GlobalVariables.offsetContinue)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
