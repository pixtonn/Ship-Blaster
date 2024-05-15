using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRegularShotController : MonoBehaviour
{
    public float speed = 30.0f;

    private float offsetContinue = 10.0f; // how much further past the edge of the map the shot goes, makes sure it doesn't disappear prematurely on screen
    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(speed * Time.deltaTime * Vector3.forward);

        // destroy itself if out of bounds
        if (transform.position.z > GlobalVariables.top+offsetContinue)
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
