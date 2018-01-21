using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityScript;


using System;
using UnityStandardAssets.Characters.FirstPerson;

public class PauseROOT : MonoBehaviour {























    public CursorLockMode CursorFreeMove;
    public CursorLockMode CursorNoMove;
    public Image pauseGuiRoot;
    public GameObject pauseGUI;
    public FirstPersonController controller2;
    private FirstPersonController Fpc;
    public bool cursorLocked;
    void Start () {




        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        cursorLocked = true;
        pauseGUI.SetActive(false);




        pauseGuiRoot.enabled = false;

       // controller2 = GameObject.Find("FirstPersonController").GetComponent<FirstPersonController>();

        //Fpc = GameObject.Find("FirstPersonController").GetComponent<FirstPersonController>();
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    void Update () {




        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (pauseGUI.activeInHierarchy == true)
            {
                pauseGUI.SetActive(false);
                cursorLocked = true;
                Cursor.visible = false;
                Cursor.lockState = CursorLockMode.Locked;

                pauseGuiRoot.enabled = false;
                controller2.enabled = true;
                return;

            }
           if (pauseGUI.activeInHierarchy == false)
            {
               
                pauseGUI.SetActive(true);
                cursorLocked = false;
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;





                pauseGuiRoot.enabled = true;
                controller2.enabled = false;
                return;
            }

           






         //   Fpc.enabled = false;
        }
       // else
       // {
            
      //      pauseGuiRoot.enabled = false;
      //      controller2.enabled = true;
          //  Fpc.enabled = true;
      //  }
     


	}
}
