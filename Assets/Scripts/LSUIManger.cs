using UnityEngine;
using UnityEngine.UI;

public class LSUIManger : MonoBehaviour
{

    public static LSUIManger instance;
    
    public Image fadeScreen;
    public float fadeSpeed;
    private bool _shouldFadeToBlack, _shouldFadeFromBlack;
    
    void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        FadeFromBlack();
    }
    
    void Update()
    {
        if (_shouldFadeToBlack)
        {
            fadeScreen.color = new Color(fadeScreen.color.r, fadeScreen.color.g, fadeScreen.color.b, Mathf.MoveTowards(fadeScreen.color.a, 1f, fadeSpeed * Time.deltaTime));
            if (fadeScreen.color.a == 1f)
            {
                _shouldFadeToBlack = false;
            }
        }

        if (_shouldFadeFromBlack)
        {
            fadeScreen.color = new Color(fadeScreen.color.r, fadeScreen.color.g, fadeScreen.color.b, Mathf.MoveTowards(fadeScreen.color.a, 0f, fadeSpeed * Time.deltaTime));
            if (fadeScreen.color.a == 0f)
            {
                _shouldFadeFromBlack = false;
            }
        }
    }

    public void FadeToBlack()
    {
        _shouldFadeToBlack = true;
        _shouldFadeFromBlack = false;
    }

    public void FadeFromBlack()
    {
        _shouldFadeFromBlack = true;
        _shouldFadeToBlack = false;
    }

    
}
