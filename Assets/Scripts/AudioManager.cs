using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FMODUnity;
using FMOD.Studio;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance { get; private set; }

    private EventInstance wind;
    private EventInstance wolf;


    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogError("Found more than one audio Manager in the scene");
        }
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        wind = AudioManager.instance.CreateEventInstance(FMODEvents.instance.wind);
    }

    // Update is called once per frame
    void Update()
    {
        WindSound();
    }

    public EventInstance CreateEventInstance(EventReference eventReference)
    {
        EventInstance eventInstance = RuntimeManager.CreateInstance(eventReference);
        return eventInstance;
    }

    public void WindSound()
    {
        PLAYBACK_STATE playbackState;
        wind.getPlaybackState(out playbackState);
        if (playbackState.Equals(PLAYBACK_STATE.STOPPED))
        {
            wind.start();
        }
    }

    public void WolfSound()
    {
        PLAYBACK_STATE playbackState;
        wolf.getPlaybackState(out playbackState);
        if (playbackState.Equals(PLAYBACK_STATE.STOPPED))
        {
            wolf.start();
        }
    }
}

