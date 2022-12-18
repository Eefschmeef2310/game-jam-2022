using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMusic : MonoBehaviour
{
    public AudioSource source;
    public List<AudioClip> clips;
    void Start()
    {
        StartCoroutine(PlayMusic());
    }
    IEnumerator PlayMusic()
    {
        yield return new WaitForSeconds(source.clip.length);
        source.loop = true;
        source.clip = clips[1];
        source.Play();
    }
}
