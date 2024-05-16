using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericEnemyDeath : MonoBehaviour
{
    public GameObject deathAnimation;
    void Start()
    {
        StartCoroutine(nameof(RemoveSelf));
    }


    private IEnumerator RemoveSelf()
    {
        deathAnimation.GetComponent<ParticleSystem>().Play();
        yield return new WaitForSeconds(5);
        Destroy(gameObject);
    }
}
