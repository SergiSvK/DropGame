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

                Instantiate(pickUpEffect, transform.position, transform.rotation);
                
                isCollected = true;
                Destroy(gameObject);
            }

            if (isHeal)
            {
                if (PlayerHealthController.instance.currentHealth == PlayerHealthController.instance.maxHealth) return;
                PlayerHealthController.instance.HealPlayer();

                isCollected = true;
                Destroy(gameObject);
            }
            
        }
    }
}
