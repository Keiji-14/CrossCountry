using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 音のミュートの管理
/// </summary>
public class AudioController : MonoBehaviour
{
    AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        audioSource.mute = AudioManager.isMute;
    }
}
