using UnityEngine;

using System.Collections;



public class ThrowObject : MonoBehaviour

{

    public Transform player;

    public Transform playerCam;

    public Camera camera;
    public float throwForce = 10;
    private float forceForce = 1;

    bool hasPlayer = false;

    bool beingCarried = false;





    public int dmg;

    private bool touched = false;



    void Start()

    {



    }



    void Update()

    {
        
        Ray ray = camera.ScreenPointToRay(Input.mousePosition);
        float dist = Vector3.Distance(gameObject.transform.position, player.position);

        if (dist <= 5.5f)

        {
            
            hasPlayer = true;

        }

        else

        {

            hasPlayer = false;

        }
        
        if (hasPlayer && Input.GetMouseButtonDown(1))

        {

            GetComponent<Rigidbody>().isKinematic = true;

            transform.parent = playerCam;

            beingCarried = true;


            

        }

        if (beingCarried)

        {

            if (Input.GetMouseButton(2))
            {
                GetComponent<Rigidbody>().isKinematic = false;

                transform.parent = null;

                beingCarried = false;

                GetComponent<Rigidbody>().AddForce(playerCam.forward * throwForce);
            }



        }
            if (Input.GetMouseButtonDown(0))
            {
                GetComponent<Rigidbody>().isKinematic = false;

                transform.parent = null;

                beingCarried = false;
            }
            


            }

            

        

        



    void OnTriggerEnter()

    {

        if (beingCarried)

        {

            touched = true;

        }

    }

}