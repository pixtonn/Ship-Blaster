using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float movementSpeed;
    public float shootingSpeed; // shots per 10 seconds

    public GameObject regularShot;

    private float shootingCooldown = 0;
    void Start()
    {
        
    }

    void Update()
    {
        // movement
        float xAxis = Input.GetAxis("Horizontal");
        float yAxis = Input.GetAxis("Vertical");

        if (xAxis != 0 || yAxis != 0)
        {
            transform.Translate(movementSpeed * Time.deltaTime * xAxis * Vector3.right);
            transform.Translate(movementSpeed * Time.deltaTime * yAxis * Vector3.forward);
            
            // now check if out of bounds, and move back in if the player is out
            if (transform.position.x < -GlobalVariables.leftRight || transform.position.x > GlobalVariables.leftRight)
            {
                transform.Translate(movementSpeed * Time.deltaTime * xAxis * -Vector3.right);
            }
            if (transform.position.z > GlobalVariables.top || transform.position.z < GlobalVariables.bottom)
            {
                transform.Translate(movementSpeed * Time.deltaTime * yAxis * -Vector3.forward);
            }
        }

        // shooting
        shootingCooldown -= Time.deltaTime;
        if (Input.GetKey(KeyCode.Space) && shootingCooldown <= 0)
        {
            shootingCooldown = 10 / shootingSpeed;
            Instantiate(regularShot, transform.position, regularShot.transform.rotation);
        }
    }
}
