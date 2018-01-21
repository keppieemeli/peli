using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrinksScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Debug.DrawLine(ray.origin, Camera.main.transform.forward * 50000000, Color.red);


    }
}
