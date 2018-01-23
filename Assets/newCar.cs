using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Vehicles.Car;
using UnityStandardAssets.Characters.FirstPerson;

public class newCar : MonoBehaviour {
    public GameObject ThisCar;
    public GameObject ActualCarSomething;
    public bool Incar;
    public bool InCarRange;
    private float distance;
    private float maxDis = 7f;
    public GameObject CameraPath;
    public GameObject FPSHuman;
    public GameObject FPSController;
    public Transform PlayerCam;
    public GameObject PlayerTemplocation;
    public float CurrentSpeed;
    public Text CurrentSpeedText;





    // Use this for initialization
    void Start () {
        
        ThisCar.GetComponent<CarController>().enabled = false;
        ThisCar.GetComponent<CarAudio>().enabled = false;
        ThisCar.GetComponent<CarUserControl>().enabled = false;
        CameraPath.SetActive(false);
        FPSController.SetActive(true);
        PlayerCam = Camera.main.transform;
        CurrentSpeedText.color = Color.black;

        


    }

    // Update is called once per frame
    void Update() {
        
        CurrentSpeed = ThisCar.GetComponent<Rigidbody>().velocity.magnitude * 4f;
        CurrentSpeedText.text = CurrentSpeed.ToString() + "KM/H";
        if (CurrentSpeed <= 14.9999)
        {
            CurrentSpeedText.color = Color.black;
        }
        if (CurrentSpeed >= 15)
        {
            CurrentSpeedText.color = Color.red;
        }
        if(CurrentSpeed >= 50)
        {
            CurrentSpeedText.color = Color.blue;
        }
        if(CurrentSpeed >= 80)
        {
            CurrentSpeedText.color = Color.green;
        }
        if (Input.GetKeyDown(KeyCode.G) && Incar == true)
        {
            Incar = false;
            ThisCar.GetComponent<CarController>().enabled = false;
            ThisCar.GetComponent<CarAudio>().enabled = false;
            ThisCar.GetComponent<CarUserControl>().enabled = false;
            FPSHuman.SetActive(true);
            
            CameraPath.SetActive(false);
            Incar = false;
            FPSController.SetActive(true);
            FPSHuman.transform.position = ActualCarSomething.transform.position + new Vector3(0, 5, 0);
        }
        
        var fwd = ThisCar.transform.TransformDirection(Vector3.forward);
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        distance = Vector3.Distance(ThisCar.transform.position, Camera.main.transform.position);
        if(Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, maxDis)) {
            InCarRange = true;
            if (Input.GetKeyDown(KeyCode.E) && Incar == false)
            {
                Incar = true;
                ThisCar.GetComponent<CarController>().enabled = true;
                ThisCar.GetComponent<CarAudio>().enabled = true;
                ThisCar.GetComponent<CarUserControl>().enabled = true;
                CameraPath.SetActive(true);
                FPSController.transform.position = PlayerTemplocation.transform.position;
                FPSHuman.SetActive(false);
                FPSController.SetActive(false);

            }
        }
        if (Input.GetKeyDown(KeyCode.G) && Incar == true)
        {
            ThisCar.GetComponent<CarController>().enabled = false;
            ThisCar.GetComponent<CarAudio>().enabled = false;
            ThisCar.GetComponent<CarUserControl>().enabled = false;
            FPSHuman.SetActive(true);
            CameraPath.SetActive(false);

            
            Incar = false;
            PlayerTemplocation.transform.position = ThisCar.transform.position;
            FPSController.transform.position = ThisCar.transform.position;
        }
        if (Incar == true)
        {

            





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
