using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LSManager : MonoBehaviour
{
    public LSPlayer player;

    public void LoadLevel()
    {
        StartCoroutine(LoadLevelCo());
    }

    private IEnumerator LoadLevelCo()
    {
        LSUIManger.instance.FadeToBlack();
        
        yield return new WaitForSeconds((1f / LSUIManger.instance.fadeSpeed) + 0.25f);

        SceneManager.LoadScene(player.currentPoint.levelToLoad);
    }
}
