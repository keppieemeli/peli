using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rahasc : MonoBehaviour {

    public float rahat = 2500;

    public Text rahaa;
    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {

        rahaa.text = "Cash: " + rahat.ToString()+"€";
        
    }

}
