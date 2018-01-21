using UnityEngine;
using System.Collections;

public class BigDoorScript : MonoBehaviour
{
    private bool doorOpen = false;
    private Ray ray;
    private RaycastHit hit;
    private float distance = 5.0f;
    public Object triggeri;


    public void OnTriggerEnter(Collider triggeri)
    {
        gameObject.transform.Translate(new Vector3(0.0f, 0.0f, 2.65f));
        doorOpen = true;
    }
    public void OnTriggerExit(Collider triggeri)
    {
        gameObject.transform.Translate(new Vector3(0.0f, 0.0f, -2.65f));
        doorOpen = false;

    }



    private void Update()
    {

        
       

        if (Input.GetKeyDown("e"))
        {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, distance))
            {
                if (!doorOpen)
                {
                    gameObject.transform.Translate(new Vector3(0.0f, 0.0f, 2.65f));
                    doorOpen = true;
                }
                else
                {
                    gameObject.transform.Translate(new Vector3(0.0f, 0.0f, -2.65f));
                    doorOpen = false;
                }
            }
        }
    }
}