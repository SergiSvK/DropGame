using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public bool isGem, isHeal;

    private bool isCollected;

    public GameObject pickUpEffect;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !isCollected)
        {
            if (isGem)
            {
                LevelManager.instance.gemCollected++;
                
                UIController.instance.UpdateGemCount();

                var transform1 = transform;
                Instantiate(pickUpEffect, transform1.position, transform1.rotation);
                
                isCollected = true;
                
                AudioManager.intance.PlaySFX(9);
                Destroy(gameObject);
            }

            if (isHeal)
            {
                if (PlayerHealthController.instance.currentHealth == PlayerHealthController.instance.maxHealth) return;
                PlayerHealthController.instance.HealPlayer();

                isCollected = true;
                AudioManager.intance.PlaySFX(7);
                Destroy(gameObject);
            }
            
        }
    }
}
