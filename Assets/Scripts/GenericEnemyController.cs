using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericEnemyController : MonoBehaviour
{
    public float speed = 10.0f;

    private bool escaped;

    public GameObject deathAnimation;
    void Start()
    {
        escaped = false;
    }

    // moves down the screen until destroyed or it hits the bottom of the map
    void Update()
    {
        transform.Translate(speed * Time.deltaTime * -Vector3.forward, Space.World);
        if (transform.position.z < GlobalVariables.bottom-GlobalVariables.offsetContinue)
        {
            escaped = true;
            Destroy(gameObject);
        }
    }


    private void OnDestroy()
    {
        if (gameObject.scene.isLoaded && !escaped)
        {
            Instantiate(deathAnimation, transform.position, deathAnimation.transform.rotation);
        }
    }
}
