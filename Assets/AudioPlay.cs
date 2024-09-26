using UnityEngine;
using System.Collections; 

public class AudioSwitch : MonoBehaviour
{
    public AudioSource IntroMusic; 
    public AudioSource GhostNormal; 
    public float delay = 5.0f;

    void Start()
    {
        
        IntroMusic.Play();

        
        StartCoroutine(SwitchAudioAfterDelay());
    }

    IEnumerator SwitchAudioAfterDelay()
    {
        
        yield return new WaitForSeconds(delay);

        
        IntroMusic.Stop();

        
        GhostNormal.Play();
    }
}


