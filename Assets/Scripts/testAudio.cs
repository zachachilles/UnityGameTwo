using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testAudio : MonoBehaviour {

    public AudioClip testMusic;
    public AudioSource testSource;

	// Use this for initialization
	void Start () {
        testSource.clip = testMusic;

	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            testSource.Play();
        }
	}
}
