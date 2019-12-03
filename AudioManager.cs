using UnityEngine.Audio;
using System;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    Playermovement Player;
    public Sound[] sounds;

    public static AudioClip coinsound;

    // Use this for initialization
    void Awake()
    {
        foreach (Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;


            s.source.volume = s.Volume;
            s.source.pitch = s.pitch;
        }
    }

    private void Start()
    {
        Play("level Theme Song");
        
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Play("ShootBullet");         
        }

        if(gameObject.tag == "Player")
        {
            Play("Coins"); 
        }

        
    }

    private void OnCollisionEnter2D()
    {
        throw new NotImplementedException();
    }

    public void Play(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        s.source.Play();

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //throw new NotImplementedException();

        if (collision.gameObject.tag == "Player")
        {
                Play("Coins");
        }
    }
}
