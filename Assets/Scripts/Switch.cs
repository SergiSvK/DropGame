using UnityEngine;

public class Switch : MonoBehaviour
{

    public GameObject objectToSwitch;

    private SpriteRenderer _theSr;
    public Sprite downSprite;

    private bool _hasSwitched;

    public bool deactivateOnSwitch;
    
    void Start()
    {
        _theSr = GetComponent<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.CompareTag("Player") || _hasSwitched) return;
        if(deactivateOnSwitch)
        {
            objectToSwitch.SetActive(false);
            AudioManager.instance.PlaySfx(13);
        } else
        {
            objectToSwitch.SetActive(true);
        }

        _theSr.sprite = downSprite;
        _hasSwitched = true;


    }
}
