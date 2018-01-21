using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;
using UnityStandardAssets.Characters.FirstPerson;

public class newCar : MonoBehaviour {
    public GameObject ThisCar;
    public bool Incar;
    public bool InCarRange;
    private float distance;
    private float maxDis = 7f;
    public GameObject CameraPath;
    public GameObject FPSHuman;
    public GameObject PlayerTemplocation;
	// Use this for initialization
	void Start () {
        ThisCar.GetComponent<CarController>().enabled = false;
        ThisCar.GetComponent<CarAudio>().enabled = false;
        ThisCar.GetComponent<CarUserControl>().enabled = false;
        CameraPath.SetActive(false);
    }

    // Update is called once per frame
    void Update() {
        var fwd = ThisCar.transform.TransformDirection(Vector3.forward);
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        distance = Vector3.Distance(ThisCar.transform.position, Camera.main.transform.position);
        if(Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, maxDis)) {
            InCarRange = true;
            if (Input.GetKeyDown(KeyCode.E) && Incar == false)
            {
                Incar = true;
            }
        }
        if (Input.GetKeyDown(KeyCode.G) && Incar == true)
        {
            Incar = false;
            FPSHuman.transform.position = ThisCar.transform.position + new Vector3(0, 5, 0);
        }
        if (Incar == true)
        {
            ThisCar.GetComponent<CarController>().enabled = true;
            ThisCar.GetComponent<CarAudio>().enabled = true;
            ThisCar.GetComponent<CarUserControl>().enabled = true;
            CameraPath.SetActive(true);
            FPSHuman.transform.position = PlayerTemplocation.transform.position;
            FPSHuman.SetActive(false);
            





        }
        if(Incar == false)
        {
            ThisCar.GetComponent<CarController>().enabled = false;
            ThisCar.GetComponent<CarAudio>().enabled = false;
            ThisCar.GetComponent<CarUserControl>().enabled = false;
            FPSHuman.SetActive(true);
            CameraPath.SetActive(false);
            FPSHuman.SetActive(true);
        }


    }
}
