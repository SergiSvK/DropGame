using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Hurtbox : MonoBehaviour
{
    public GameObject deathEffect;
    [Range(0,100)]public float chanceToDrop;
    public GameObject collectible;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            Transform otherTransform;
            (otherTransform = other.transform).parent.gameObject.SetActive(false);

            Instantiate(deathEffect,otherTransform.position, otherTransform.rotation);
            
            PlayerController.intance.Bounce();

            var dropSelect = Random.Range(0, 100f);

            if (dropSelect <=chanceToDrop)
            {
                Instantiate(collectible, otherTransform.position, otherTransform.rotation);
            }
        }
    }
}
