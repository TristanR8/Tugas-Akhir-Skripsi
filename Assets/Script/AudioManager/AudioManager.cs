using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;

    [System.Serializable]
    public class Sound
    {
        public string nama;
        public AudioClip clip;
    }

    [Header("Audio Source")]
    public AudioSource bgmSource;
    public AudioSource sfxSource;

    [Header("BGM")]
    public List<Sound> bgmSound = new List<Sound>();

    [Header("SFX")]
    public List<Sound> sfxSound = new List<Sound>();

    void Start()
    {
        PlayBGM("Theme");
        PlayBGM("Theme2");
        PlayBGM("Theme3");
    }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void PlayBGM(string nama)
    {
        foreach (Sound s in bgmSound)
        {
            if (s.nama == nama)
            {
                bgmSource.clip = s.clip;
                bgmSource.Play();
                return;
            }
        }

        Debug.LogWarning("BGM tidak ditemukan: " + nama);
    }

    public void PlaySFX(string nama)
    {
        foreach (Sound s in sfxSound)
        {
            if (s.nama == nama)
            {
                sfxSource.PlayOneShot(s.clip);
                return;
            }
        }

        Debug.LogWarning("SFX tidak ditemukan: " + nama);
    }
    public void StopBGM()
    {
        bgmSource.Stop();
    }
}