using UnityEngine;

public class LevelExit : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            LevelManager.instance.EndLevel();
        }
    }
}
