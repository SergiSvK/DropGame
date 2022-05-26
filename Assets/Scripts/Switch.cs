using UnityEngine;

public class Switch : MonoBehaviour
{

    public GameObject objectToSwitch;

    private SpriteRenderer theSR;
    public Sprite downSprite;

    private bool _hasSwitched;

    public bool deactivateOnSwitch;
    
    void Start()
    {
        theSR = GetComponent<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.CompareTag("Player") || _hasSwitched) return;
        if(deactivateOnSwitch)
        {
            objectToSwitch.SetActive(false);
            AudioManager.intance.PlaySfx(13);
        } else
        {
            objectToSwitch.SetActive(true);
        }

        theSR.sprite = downSprite;
        _hasSwitched = true;


    }
}
