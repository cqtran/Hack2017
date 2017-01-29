using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]

public class audio : MonoBehaviour {

    public AudioClip engineStartClip;
    public AudioClip engineLoopClip;
	public AudioClip worstvarname;

    void Start()
    {
        GetComponent<AudioSource>().loop = false;
        StartCoroutine(playEngineSound());
    }

    IEnumerator playEngineSound()
    {
        GetComponent<AudioSource>().clip = engineStartClip;
        GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(GetComponent<AudioSource>().clip.length);
        GetComponent<AudioSource>().clip = engineLoopClip;
        GetComponent<AudioSource>().Play();

		yield return new WaitForSeconds(GetComponent<AudioSource>().clip.length);
		GetComponent<AudioSource>().clip = worstvarname;
		GetComponent<AudioSource>().Play();
    }
}
