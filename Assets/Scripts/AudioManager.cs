using UnityEngine;
using Random = UnityEngine.Random;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;

    public AudioSource[] soundEffects;

    private void Awake()
    {
        instance = this;
    }

    public void PlaySfx(int soundToPlay)
    {
        soundEffects[soundToPlay].Stop();

        soundEffects[soundToPlay].pitch = Random.Range((float) .9,1.1f);
        
        soundEffects[soundToPlay].Play();
    }
}
