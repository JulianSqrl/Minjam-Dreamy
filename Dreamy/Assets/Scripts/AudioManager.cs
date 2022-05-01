using UnityEngine.Audio;
using System;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public Sound[] sounds;


    // Start is called before the first frame update
    void Start()
    {

        foreach(Sound s in sounds)
        {
            s.source=gameObject.AddComponent<AudioSource>();

            s.source.clip = s.clip;

            s.source.volume = s.volume;

            s.source.pitch = s.pitch;

            s.source.loop = s.loop;
        }
        
    }


    public void SetPitch(string name,float pitch)
    {
        Sound s = Array.Find<Sound>(sounds,sound => sound.name == name);
        s.pitch = pitch;
        s.source.pitch = s.pitch;
    }
    public void Play(string name)
    {
        Sound s = Array.Find<Sound>(sounds,sound => sound.name == name);

        if(s.source.isPlaying == false)
        {
            s.source.Play();
        }
    }
}
