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
        
        LSUIManger.intance.FadeFromBlack();
        yield return new WaitForSeconds(((1f)/ LSUIManger.intance.fadeSpeed) + .25f);

        SceneManager.LoadScene(player.currentPoint.levelToLoad);
    }
}
