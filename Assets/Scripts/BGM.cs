using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGM : MonoBehaviour
{
    public AudioClip[] clips;
    private AudioSource source;
    
    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
        source.loop = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!source.isPlaying)
        {
            int clipIndex = Random.Range(0, clips.Length);
            source.clip = clips[clipIndex];
            source.Play();
        }
    }
}
