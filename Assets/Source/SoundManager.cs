using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {


    public AudioClip[] audioClips;
    public int[] times;
    float timer = 0;
    int cur = 0;

    bool playNext = true;

    // Use this for initialization
    void Start () {
        playAudio(cur);
	}
	
	// Update is called once per frame
	void Update () {
        if (playNext)
        {
            if (timer > 0)
                timer -= Time.deltaTime;
            else
                playAudio(cur);
        }
	}

    void playAudio(int clipNumber)
    {
        AudioSource audio = GetComponent<AudioSource>();
        audio.clip = audioClips[clipNumber];
        audio.Play();
        timer = times[cur];
        cur++;

        if (cur >= audioClips.Length)
            Application.LoadLevel(Application.loadedLevel);

    }
}
