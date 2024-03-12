using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FMODUnity;
using FMOD.Studio;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance { get; private set; }

    private EventInstance wind;
    private EventInstance wolf;
    private EventInstance sceneMusic;
    private EventInstance menuMusic;

    public Scene scene;


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
        sceneMusic = AudioManager.instance.CreateEventInstance(FMODEvents.instance.sceneMusic);
        menuMusic = AudioManager.instance.CreateEventInstance(FMODEvents.instance.menuMusic);
        scene = SceneManager.GetActiveScene();
    }

    // Update is called once per frame
    void Update()
    {
        WindSound();
        SceneMusic();
        MenuMusic();
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

    public void SceneMusic()
    {
        PLAYBACK_STATE playbackState;
        sceneMusic.getPlaybackState(out playbackState);
        if (playbackState.Equals(PLAYBACK_STATE.STOPPED))
        {
            sceneMusic.start();
        }
    }

    public void MenuMusic()
    {
        if(scene.name == "MainMenu")
        {
            PLAYBACK_STATE playbackState;
            menuMusic.getPlaybackState(out playbackState);
            if (playbackState.Equals(PLAYBACK_STATE.STOPPED))
            {
                menuMusic.start();
            }
        }
    }

    public void ClearMusic()
    {
        menuMusic.stop(STOP_MODE.IMMEDIATE);
    }
}

