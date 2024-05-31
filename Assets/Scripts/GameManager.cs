using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject player;
    public Text pickupText;

    // Audo Vars
    public AudioSource[] audioSources;
    public float audioProximity = 5.0f;

    // Level Vars
    public int currentPickups = 0;
    public int maxPickups = 5;
    public bool levelComplete = false;

    void Start()
    {
        //Preloads audio at start of scene to prevent lag, mostly for my Claire de Lune music clip - Brian
        foreach (AudioSource source in audioSources)
        {
            source.clip.LoadAudioData();
        }
    }

    void Update()
    {
        UpdateGUI();
        LevelCompleteCheck();
        PlayAudioSamples();
    }

    private void UpdateGUI()
    {
        pickupText.text = "Objects Eaten: " + currentPickups + "/" + maxPickups;
    }

    private void LevelCompleteCheck()
    {
        if (currentPickups >= maxPickups) levelComplete = true;
        else levelComplete = false;
    }

    private void PlayAudioSamples()
    {
        for (int i = 0; i < audioSources.Length; i++)
        {
            if (Vector3.Distance(player.transform.position, audioSources[i].transform.position) <= audioProximity)
            {
                if (!audioSources[i].isPlaying)
                {
                    audioSources[i].Play();
                }
            }
        }
    }
}
 