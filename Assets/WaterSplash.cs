using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterSplash : MonoBehaviour {
	public AudioClip Splash;
		

	private AudioSource source;
	// Use this for initialization
	void Awake () {
		source = GetComponent<AudioSource>();
	}



	// Update is called once per frame
	void Update () {
		
	}


	public void OnTriggerEnter() {
	
		source.PlayOneShot (Splash, 1f);
	
	}

}
