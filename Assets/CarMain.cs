using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMain : MonoBehaviour {
    private float distance;
    public float Speed = 10f;
    private float maxDis = 5f;
    public GameObject BackTierRight;
    public GameObject BackTierLeft;
    
    public bool InCar = false;
    public bool InCarRange = false;
    private float y = 0f;
    private float z = 0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        

        
        var fwd = transform.TransformDirection(Vector3.forward);
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        distance = Vector3.Distance(transform.position, Camera.main.transform.position);


        if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, maxDis)) {
            InCarRange = true;
            if (Input.GetKeyDown(KeyCode.E) && InCar == false)
            {
                InCar = true;
            }
        }
        else
        {
            InCarRange = false;
        }
        if (Input.GetKeyDown(KeyCode.G) && InCar == true)
        {
            InCar = false;
        }



            if (Input.GetKey(KeyCode.W) && InCar == true)
        {
            BackTierLeft.transform.Rotate(Vector3.up * Speed * Time.deltaTime);
            BackTierRight.transform.Rotate(Vector3.up * Speed * Time.deltaTime);
            
        }






	}
}
