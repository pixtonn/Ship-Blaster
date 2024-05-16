using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericEnemyDeath : MonoBehaviour
{
    public GameObject deathAnimation;
    public GameObject deathSound;
    void Start()
    {
        StartCoroutine(nameof(RemoveSelf));
    }


    private IEnumerator RemoveSelf()
    {
        GameManager.Instance.AddScore(GlobalVariables.genericEnemyPointValue);
        deathAnimation.GetComponent<ParticleSystem>().Play();
        deathSound.GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(5);
        Destroy(gameObject);
    }
}
