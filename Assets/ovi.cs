using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ovi : MonoBehaviour {
    
    public Animator anim;
    
	// Use this for initialization
	void Start () {
        anim.SetBool("ovijutttu", false);
    }
    void OnTriggerEnter(Collider other)
    {

        anim.SetBool("ovijutttu", true);
    }
    private void OnTriggerExit(Collider other)
    {
        anim.SetBool("ovijutttu", false);
    }

    // Update is called once per frame
    void Update () {
		
	}
}
