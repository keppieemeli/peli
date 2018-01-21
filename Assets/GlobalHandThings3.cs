using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
public class GlobalHandThings3 : MonoBehaviour
{
    public GameObject ItselfGlobal;
    public GameObject Log1;
    public GameObject Log2;
    public GameObject FireText;
    public GameObject HandOpen;
    public GameObject HandClosed;
    public float distance;
    public float maxDis = 5f;
    public Camera playerCam;
    public CharacterController controller;
    // Use this for initialization
    void Start()
    {
        CharacterController controller = GetComponent<CharacterController>();
        FireText.SetActive(false);
        HandClosed.SetActive(false);
        HandOpen.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        var fwd = transform.TransformDirection(Vector3.forward);
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (ItselfGlobal.GetComponent<DragLog2>().Fire == false)
        {

            if (ItselfGlobal.GetComponent<DragLog2>().WoodImage.activeInHierarchy == true)
            {

                if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, maxDis) && hit.transform.tag == "FireLog3")
                {
                    Log1.GetComponent<GlobalHandThings>().enabled = false;
                    Log2.GetComponent<GlobalHandThings2>().enabled = false;
                    distance = Vector3.Distance(transform.position, Camera.main.transform.position);
                    if (ItselfGlobal.GetComponent<DragLog2>().dragging == true)
                    {
                        HandClosed.SetActive(true);
                        HandOpen.SetActive(false);
                    }
                    else
                    {
                        HandOpen.SetActive(true);
                        FireText.SetActive(true);
                    }
                }
                else
                {
                    FireText.SetActive(false);
                    HandOpen.SetActive(false);
                    HandClosed.SetActive(false);
                    Log1.GetComponent<GlobalHandThings>().enabled = true;
                    Log2.GetComponent<GlobalHandThings2>().enabled = true;
                }
            }
            else
            {
                FireText.SetActive(false);
                HandOpen.SetActive(false);
                HandClosed.SetActive(false);
                Log1.GetComponent<GlobalHandThings>().enabled = true;
                Log2.GetComponent<GlobalHandThings2>().enabled = true;
            }

        }
        else
        {
            FireText.SetActive(false);
            HandOpen.SetActive(false);
            HandClosed.SetActive(false);
            Log1.GetComponent<GlobalHandThings>().enabled = true;
            Log2.GetComponent<GlobalHandThings2>().enabled = true;
        }


    }
}
