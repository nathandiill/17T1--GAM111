using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {

    public static SoundManager Instance;

    void Awake()
    {
        Instance = this;
    }

    public AudioClip[] EventSounds;
    public AudioSource SFXChannel;

    public void TennisNetSound()
    {
        AudioClip tennisNetSound = EventSounds[0];
        SFXChannel.PlayOneShot(tennisNetSound);
    }

    public void UmpireSound()
    {
        AudioClip UmpireSound = EventSounds[1];
        SFXChannel.PlayOneShot(UmpireSound);
    }
}
