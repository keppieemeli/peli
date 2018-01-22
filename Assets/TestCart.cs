using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
public class TestCart : MonoBehaviour {
    public GameObject ThisTestCrat;
    public GameObject Tire1;
    public GameObject Tire2;
    public GameObject Tire3;
    public GameObject tire4;
    public GameObject PlayerTempLocation;
    public float Smooth;
    public float Speed;
    public float HighSpeed;
    private float BackSpeed = 7f;
    public float TurningSpeed;
    public float TurningSpeedLeft;
    public float UpsideDownSpeed;
    public GameObject CameraPath;
    public GameObject FPSMovement;
    public GameObject Player;
    public bool InCarCurrently;
    public Transform PlayerCam;

    public Camera NewCarCamera;
    private float maxDis = 7f;
    private float distance;
    private bool CarSomething;
    public GameObject GetInCarText;
   



    private bool RotatingLeft;
    private bool RotatingRight;

    // Use this for initialization
    void Start () {
        PlayerCam = Camera.main.transform;
        GetInCarText.SetActive(false);
        CarSomething = false;
        CameraPath.SetActive(false);
        
    }
    public void InCar()
    {




        //PlayerCam.transform.position = ThisTestCrat.transform.position;
        CameraPath.SetActive(true);
        
        FPSMovement.GetComponent<FirstPersonController>().m_RunSpeed = 0f;
        FPSMovement.GetComponent<FirstPersonController>().m_WalkSpeed = 0f;
        FPSMovement.GetComponent<FirstPersonController>().enabled = false;

        
        

    }
    // Update is called once per frame
    void Update() {

        if (InCarCurrently == true)
        {

            FPSMovement.transform.position = PlayerTempLocation.transform.position;


            if (Input.GetKey(KeyCode.G))
            {

                FPSMovement.GetComponent<FirstPersonController>().m_RunSpeed = 6f;
                FPSMovement.GetComponent<FirstPersonController>().m_WalkSpeed = 3f;
                FPSMovement.GetComponent<FirstPersonController>().enabled = true;
                FPSMovement.transform.position = ThisTestCrat.transform.position + new Vector3(0, 5, 0);
                CameraPath.SetActive(false);
                InCarCurrently = false;
            }
            if (Input.GetKeyDown(KeyCode.U))
            {
                Vector3 UpsideDown = new Vector3(0, 0, 0);

                
                
                


            }

            if (Input.GetKey(KeyCode.S))
            {
                Vector3 BackWard = NewCarCamera.transform.forward;
                ThisTestCrat.transform.position -= BackWard * BackSpeed * Time.deltaTime;

            }

            if (Input.GetKey(KeyCode.W))
            {
                Vector3 forward = NewCarCamera.transform.forward;
                ThisTestCrat.transform.position += forward * Speed * Time.deltaTime;
                if (Input.GetKey(KeyCode.LeftShift))
                {
                    
                    ThisTestCrat.transform.position += forward * HighSpeed * Time.deltaTime;
                }




            }
            if (Input.GetKey(KeyCode.D))
            {
                ThisTestCrat.transform.Rotate(0, +TurningSpeed, 0);

            }
            
            if (Input.GetKey(KeyCode.A))
            {
                ThisTestCrat.transform.Rotate(0, +TurningSpeedLeft, 0);
            }
            

        }

        var fwd = transform.TransformDirection(Vector3.forward);
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        distance = Vector3.Distance(transform.position, Camera.main.transform.position);

        if (distance <= maxDis)
        {
            GetInCarText.SetActive(true);
            CarSomething = true;
        }
        else if (distance >= maxDis + 0.00001f)
        {
            GetInCarText.SetActive(false);
            CarSomething = false;
        }

        if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, maxDis))
            {
            if (CarSomething == true)
            {
                if (Input.GetKey(KeyCode.E))
                {
                    InCarCurrently = true;
                    InCar();

                }
            }
            if(CarSomething == false)
            {
                return;
            }
            }
        


        
        
        
    }
    
}
