using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour
{
    public int backgroundSpeed;

    private float repeatLength;

    void Start()
    {
        repeatLength = transform.localScale.z / 3 * 10; // length of plane multipled by 10 because a plane is a 10x10 to start with and the z only tells me the scale
        // it is divided by 3 because the background repeats 3 times
    }

    void Update()
    {
        transform.Translate(backgroundSpeed * Time.deltaTime * -Vector3.forward);
        if (transform.position.z <= -repeatLength/2)
        {
            transform.Translate(repeatLength * Vector3.forward);
        }
    }
}
