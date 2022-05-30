using UnityEngine;

public class PickUp : MonoBehaviour
{
    public bool isGem, isHeal;

    private bool _isCollected;

    public GameObject pickUpEffect;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !_isCollected)
        {
            if (isGem)
            {
                LevelManager.instance.gemCollected++;
                
                UIController.instance.UpdateGemCount();

                var transform1 = transform;
                Instantiate(pickUpEffect, transform1.position, transform1.rotation);
                
                _isCollected = true;
                
                AudioManager.instance.PlaySfx(9);
                Destroy(gameObject);
            }

            if (isHeal)
            {
                if (PlayerHealthController.instance.currentHealth == PlayerHealthController.instance.maxHealth) return;
                PlayerHealthController.instance.HealPlayer();

                _isCollected = true;
                AudioManager.instance.PlaySfx(7);
                Destroy(gameObject);
            }
            
        }
    }
}
