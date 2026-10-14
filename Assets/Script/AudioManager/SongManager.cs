using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Timeline;

public class Song : MonoBehaviour
{

    [SerializeField]
    private AudioSource sfxAudioSource;

    [SerializeField]
    private AudioSource bgmAudioSource;

    [SerializeField]
    private List<AudioClip> sfxClip;

    [SerializeField]
    private List<AudioClip> bgmClip;

}
