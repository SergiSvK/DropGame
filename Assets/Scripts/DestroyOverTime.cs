using UnityEngine;

public class DestroyOverTime : MonoBehaviour
{
    public float lifeTime;
    
    void Update()
    {
        Destroy(gameObject,lifeTime);
    }
}
