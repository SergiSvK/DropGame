using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LSUIManger : MonoBehaviour
{

    public static LSUIManger intance;
    public Image fadeScreen;
    public float fadeSpeed;
    private bool _shouldFadeToBlack, _shouldFadeFromBlack;
    
    private void Awake()
    {
        intance = this;
    }

    private void Start()
    {
        FadeFromBlack();
    }

    private void Update()
    {
        if (_shouldFadeToBlack)
        {
            
            fadeScreen.color = new Color(fadeScreen.color.r,fadeScreen.color.g,fadeScreen.color.b,Mathf
                .MoveTowards(fadeScreen.color.a, 1f,fadeSpeed * Time.deltaTime));

            if (fadeScreen.color.a == 1f)
            {
                _shouldFadeToBlack = false;
            }
        }

        if (!_shouldFadeFromBlack) return;
        // Mathf.MoveTowards Nos permite movernos lentamente de un numero a otro
        fadeScreen.color = new Color(fadeScreen.color.r,fadeScreen.color.g,fadeScreen.color.b,Mathf
            .MoveTowards(fadeScreen.color.a, 0f,fadeSpeed * Time.deltaTime));

        if (fadeScreen.color.a == 0f)
        {
            _shouldFadeFromBlack = false;
        }
    }

    public void FadeToBlack()
    {
        _shouldFadeToBlack = true;
        _shouldFadeFromBlack = false;
    }
    
    public void FadeFromBlack()
    {
        _shouldFadeToBlack = false;
        _shouldFadeFromBlack = true;
    }
    
}
