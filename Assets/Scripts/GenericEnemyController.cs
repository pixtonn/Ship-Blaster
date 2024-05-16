using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericEnemyController : MonoBehaviour
{
    public float speed = 10.0f;

    public GameObject deathAnimation;
    void Start()
    {

    }

    // moves down the screen until destroyed or it hits the bottom of the map
    void Update()
    {
        transform.Translate(speed * Time.deltaTime * -Vector3.forward, Space.World);
        if (transform.position.z < GlobalVariables.bottom-GlobalVariables.offsetContinue)
        {
            Destroy(gameObject);
        }
    }


    private void OnDestroy()
    {
        if (gameObject.scene.isLoaded)
        {
            Instantiate(deathAnimation, transform.position, deathAnimation.transform.rotation);
        }
    }
}
