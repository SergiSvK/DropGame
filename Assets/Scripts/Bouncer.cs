using UnityEngine;

public class Bouncer : MonoBehaviour
{
    private Animator _anim;

    public float bounceForce;
    private static readonly int Bounce = Animator.StringToHash("Bounce");
    
    void Start()
    {
        _anim = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            PlayerController.instance.theRb.velocity = new Vector2(PlayerController.instance.theRb.velocity.x, bounceForce);
            _anim.SetTrigger(Bounce);
        }
    }
}
