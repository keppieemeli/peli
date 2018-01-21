using System.Collections;
using System;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;


public class DragRig222 : MonoBehaviour
{
    private Color mouseOverColor = Color.blue;
    private Color originalColor = Color.yellow;
    public bool dragging = false;
    public bool isFireTrue = false;
    public float distance;
	public float currentDis;
    
    public Rigidbody itselfRb;
    public float Weight;
   // public GameObject HandOpenObject;
    
    public GameObject FireLogText2;
    public GameObject ActualFire;
   
	public GameObject itself;
	public float maxDis = 5f;
	public Image handClosed;
	public Image handOpen;
	public float addForce = 10;
	public Camera playerCam;
    
	public float playerCurrentSpeed;
    private float SecondarySpeed;
    public CharacterController controller;


    public void Start(){

        
        
        
        CharacterController controller = GetComponent<CharacterController>();

        itselfRb = GetComponent<Rigidbody> ();


        

		
        FireLogText2.SetActive(false);
        
        

    }
    void OnMouseEnter()
    {
		
    }
    IEnumerator WaitSecond()
    {

        
        
        FireLogText2.SetActive(false);
      //  handClosed.enabled = false;
       // handOpen.enabled = false;

        Debug.Log("Time:" + Time.time);
        yield return new WaitForSeconds(5);
        Debug.Log("Time" + Time.time);

    }
    void OnMouseExit()
    {
		
    }

    void OnMouseDown()
    {
        if (isFireTrue == false)
        {
            if (distance <= maxDis)
            {

                distance = Vector3.Distance(transform.position, Camera.main.transform.position);
                dragging = true;


            }
            
        }
        
	}
	public void MouseRightClick(){
	

	
	
	}
    
    public void OnMouseUp()
    {
        dragging = false;
		//handClosed.enabled = false;
		gameObject.GetComponent<Rigidbody> ().isKinematic = false;
		gameObject.GetComponent<Rigidbody> ().useGravity = true;
		//handClosed.enabled = false;
        

    }
   



    
    void Update()
	{
        
        
        if(isFireTrue == true)
        {

            gameObject.GetComponent<Rigidbody>().isKinematic = false;
            gameObject.GetComponent<Rigidbody>().useGravity = true;
            FireLogText2.SetActive(false);
           // handOpen.enabled = false;
           // handClosed.enabled = false;
            
            gameObject.GetComponent<Rigidbody>().mass = 10f;
            
            
            
        }

        if (isFireTrue == false)
        {
            FireLog();
            Vector3 horizontalVelocity = controller.velocity;
            horizontalVelocity = new Vector3(controller.velocity.x, 0, controller.velocity.z);
            float horizontalSpeed = horizontalVelocity.magnitude;
            float verticalSpeed = controller.velocity.y;
            float overallSpeed = controller.velocity.magnitude;


            playerCurrentSpeed = controller.velocity.magnitude;

            
            



            if (distance <= maxDis)
            {

                if (dragging)
                {

                    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                    Vector3 rayPoint = ray.GetPoint(distance);
                    transform.position = rayPoint;
                    gameObject.GetComponent<Rigidbody>().isKinematic = true;
                    gameObject.GetComponent<Rigidbody>().useGravity = false;
                   // handOpen.enabled = false;
                    //handClosed.enabled = true;







                }

            }



        }
       
    }


    void FireSpreadMethod()
    {
        
            
            gameObject.GetComponent<Rigidbody>().mass = 10f;
            StartCoroutine(WaitSecond());
            
        
    }
   
    
    void FireLog()
    {
        //if (handClosed.enabled == true)
       // {
       //     handOpen.enabled = false;
       // }


        var fwd = transform.TransformDirection(Vector3.forward);
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, maxDis) && hit.transform.tag == "FireLog")
        {
            if (isFireTrue == false)
            {
                FireLogText2.SetActive(true);
                currentDis = hit.distance;


              

              // if (handClosed.enabled == true)
               // {
               //    handOpen.enabled = false;
                //}
                //else
               // {
                //    handOpen.enabled = true;
               // }
                FireLogText2.SetActive(true);


                if (Input.GetKeyDown(KeyCode.Mouse1))
                {
                    OnMouseUp();
                    Debug.Log("MRC work");
                    //itselfRb.AddForce (transform.forward * addForce);
                    itselfRb.AddForce(playerCam.transform.forward * addForce);
                    
                }

                if (Input.GetKeyDown(KeyCode.F))
                {

                    
                    
                    isFireTrue = true;
                    gameObject.GetComponent<Rigidbody>().mass = 10f;
                    FireLogText2.SetActive(false);
                    Debug.Log("Key .F. Pressed starting access to FireSpread.Burning");
                    gameObject.GetComponent<FireSpead>().Access();
                    Debug.Log("This should not be happening");
                    
                    StartCoroutine(WaitSecond());
                    
                }
                
            }
        }
        else
        {
            
            FireLogText2.SetActive(false);
        }

    }


    void FixedUpdate()
    {

        // if (itself.tag == "Drag") {
        //RaycastHit hit;
        //	Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
        //	if (Physics.Raycast (ray, out hit)) {
        //	currentDis = hit.distance;


        if (isFireTrue == false)
        {

            var fwd = transform.TransformDirection(Vector3.forward);
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);









            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, maxDis) && hit.transform.tag == "Drag")
            {

                currentDis = hit.distance;

                //handOpen.enabled = true;
                FireLogText2.SetActive(false);





                if (Input.GetKeyDown(KeyCode.Mouse1))
                {
                    OnMouseUp();
                    Debug.Log("MRC work");
                    //itselfRb.AddForce (transform.forward * addForce);
                    itselfRb.AddForce(playerCam.transform.forward * addForce);
                }







            }
            else
            {

                //handOpen.enabled = false;
                FireLogText2.SetActive(false);
            }




            //if (Physics.Raycast (transform.position ,hit ,maxDis) && hit.transform.tag == "Drag"){

            //	currentDis = hit.distance;


            //	}




        }
    }
}
