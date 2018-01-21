using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class DragLog0 : MonoBehaviour
{
    public bool Fire;
    public bool dragging;
    public float distance;
    public float currentDis;

    public Rigidbody itselfRb;
    
    public GameObject ActualFire;
    public GameObject itself;
    public float maxDis = 5f;
    
    public float addForce;
    public Camera playerCam;
    public CharacterController controller;
    public GameObject WoodImage;

    // Use this for initialization




    void Start()
    {
        
        

        CharacterController controller = GetComponent<CharacterController>();
        itselfRb = GetComponent<Rigidbody>();

    }
    public IEnumerator LightLogKeyPress()
    {
        
        gameObject.GetComponent<Rigidbody>().mass = 5f;
        OnMouseUp();
        
        yield return new WaitForSeconds(1);
        ActualFire.SetActive(true);
        gameObject.GetComponent<GlobalFireSpread>().IsFire1 = true;
        
        Fire = true;
        gameObject.GetComponent<GlobalFireSpread>().LateFireCheck1();
        yield return new WaitForSeconds(300);
        //itself.SetActive(false);
        WoodImage.SetActive(false);
        ActualFire.SetActive(false);
        Fire = false;
        gameObject.GetComponent<GlobalFireSpread>().LateFireCheck1();
        itself.GetComponent<GlobalFireSpread>().IsFire1 = false;
        gameObject.GetComponent<GlobalFireSpread>().enabled = false;
        yield return new WaitForSeconds(60);
        gameObject.GetComponent<GlobalFireSpread>().enabled = true;
        
        itself.transform.position = new Vector3(3242.29f, -367.76f, -984.11f);
        //itself.SetActive(true);
        Fire = false;
        gameObject.GetComponent<GlobalFireSpread>().LateFireCheck1();
        ActualFire.SetActive(false);
        itself.GetComponent<GlobalFireSpread>().IsFire1 = false;
        WoodImage.SetActive(true);
        gameObject.GetComponent<Rigidbody>().mass = 0.25f;
        Update();
        
    }


    // Update is called once per frame
    void Update()
    {
        
        //distance = Vector3.Distance(transform.position, Camera.main.transform.position);


        if (Fire == false)
                {
                    if (dragging)
                    {
                        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                        Vector3 rayPoint = ray.GetPoint(distance);
                        transform.position = rayPoint;
                        gameObject.GetComponent<Rigidbody>().isKinematic = true;
                        gameObject.GetComponent<Rigidbody>().useGravity = false;
                        

                    }
                    
                
                
                }

            
            
        

    }


    public void LogIsOnFire()
    {
        StartCoroutine(LightLogKeyPress());

    }
    public void FixedUpdate()
    {
        var fwd = transform.TransformDirection(Vector3.forward);
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        


        if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, maxDis) && hit.transform.tag == "FireLog1")
        {
            distance = Vector3.Distance(transform.position, Camera.main.transform.position);
            if (Fire == false && WoodImage.activeInHierarchy == true)
            {
                
               

                if (Input.GetKeyDown(KeyCode.Mouse1))
                {
                    OnMouseUp();
                    Debug.Log("Throwing Log ");
                    //itselfRb.AddForce (transform.forward * addForce);
                    itselfRb.AddForce(playerCam.transform.forward * addForce);
                    

                }

                if (Input.GetKeyDown(KeyCode.F))
                {
                   

                    
                    LogIsOnFire();
                    //Fire = true;
                    gameObject.GetComponent<Rigidbody>().mass = 5f;

                    
                    // gameObject.GetComponent<FireSpead>().Access();
                    // Debug.Log("This should not be happening");

                    // StartCoroutine(WaitSecond());

                }
            }
            
        }
        
        
    }
    void OnMouseDown()
    {
        if (Fire == false)
        {
            if (distance <= maxDis)
            {
                
                dragging = true;
                


            }
        }
    }
    public void OnMouseUp()
    {
        dragging = false;
        
        gameObject.GetComponent<Rigidbody>().isKinematic = false;
        gameObject.GetComponent<Rigidbody>().useGravity = true;

    }




}
