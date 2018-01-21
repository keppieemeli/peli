using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GlobalFireSpread : MonoBehaviour
{

    public GameObject Itself1;
    public GameObject Itself2;
    public GameObject Itself3;
    public GameObject Itself4;
    public GameObject Itself5;
    public GameObject Itself6;
    public GameObject Itself7;
    public GameObject Itself8;
    public GameObject Itself9;
    public GameObject Itself10;
    public GameObject Itself11;
    public GameObject Itself12;
    public GameObject Itself13;
    public GameObject Itself14;
    public GameObject Itself15;
    public GameObject Itself16;
    public GameObject Itself17;
    public GameObject Itself18;
    public GameObject Itself19;
    public GameObject Itself20;
    public bool IsFire1;
    public bool IsFire2;
    public bool IsFire3;
    public bool IsFire4;
    public bool IsFire5;
    public bool IsFire6;
    public bool IsFire7;
    public bool IsFire8;
    public bool IsFire9;
    public bool IsFire10;
    public bool IsFire11;
    public bool IsFire12;
    public bool IsFire13;
    public bool IsFire14;
    public bool IsFire15;
    public bool IsFire16;
    public bool IsFire17;
    public bool IsFire18;
    public bool IsFire19;
    public bool IsFire20;
    void Start()
    {

    }
    public void LateFireCheck1()
    {

        if (gameObject.GetComponent<DragLog0>().Fire == true)
        {
            IsFire1 = true;
            Itself2.GetComponent<GlobalFireSpread>().IsFire1 = true;
            Itself3.GetComponent<GlobalFireSpread>().IsFire1 = true;
        }
        if(gameObject.GetComponent<DragLog0>().Fire == false)
        {
            IsFire1 = false;
            Itself2.GetComponent<GlobalFireSpread>().IsFire1 = false;
            Itself3.GetComponent<GlobalFireSpread>().IsFire1 = false;
        }
    }
    public void LateFireCheck2()
    {
        if(gameObject.GetComponent<DragLog1>().Fire == true)
        {
            IsFire2 = true;
            Itself1.GetComponent<GlobalFireSpread>().IsFire2 = true;
            Itself3.GetComponent<GlobalFireSpread>().IsFire2 = true;
        }
        if(gameObject.GetComponent<DragLog1>().Fire == false)
        {
            IsFire2 = false;
            Itself1.GetComponent<GlobalFireSpread>().IsFire2 = false;
            Itself3.GetComponent<GlobalFireSpread>().IsFire2 = false;
        }  
    }
    public void LateFireCheck3()
    {

        if (gameObject.GetComponent<DragLog2>().Fire == true)
        {
            IsFire3 = true;
            Itself1.GetComponent<GlobalFireSpread>().IsFire3 = true;
            Itself2.GetComponent<GlobalFireSpread>().IsFire3 = true;
        }
        if (gameObject.GetComponent<DragLog2>().Fire == false)
        {
            IsFire3 = false;
            Itself1.GetComponent<GlobalFireSpread>().IsFire3 = false;
            Itself2.GetComponent<GlobalFireSpread>().IsFire3 = false;
        }
    }

    void Update()
    {
       
    }


    public void OnTriggerEnter(Collider collision)
    {
        if (Itself1.tag == "FireLog1" && IsFire1 == false)
        {
            if (collision.tag == "FireLog1(itself)" && IsFire1 == true)
            {
                Itself1.GetComponent<DragLog0>().LogIsOnFire();
                IsFire1 = true;
                Itself2.GetComponent<GlobalFireSpread>().IsFire1 = true;
                //Itself3.GetComponent<GlobalFireSpread>().IsFire1 = true;
                //Itself4.GetComponent<GlobalFireSpread>().IsFire1 = true;
                //Every Gameobject need to reAssing 
            }
            if (collision.tag == "FireLog2" && IsFire2 == true)
            {
                
                Itself1.GetComponent<DragLog0>().LogIsOnFire();
                IsFire1 = true;
                Itself2.GetComponent<GlobalFireSpread>().IsFire1 = true;
            }
            if (collision.tag == "FireLog3" && IsFire3 == true)
            {
                Itself1.GetComponent<DragLog0>().LogIsOnFire();
                IsFire1 = true;
                Itself2.GetComponent<GlobalFireSpread>().IsFire1 = true;
            }

            if (collision.tag == "FireLog4" && IsFire4 == true)
            {
                Itself1.GetComponent<DragLog0>().LogIsOnFire();
                IsFire1 = true;
                Itself2.GetComponent<GlobalFireSpread>().IsFire1 = true;
            }
            if (collision.tag == "FireLog5" && IsFire5 == true)
            {
                Itself1.GetComponent<DragLog0>().LogIsOnFire();
                IsFire1 = true;
                Itself2.GetComponent<GlobalFireSpread>().IsFire1 = true;
            }

            if (collision.tag == "FireLog6" && IsFire6 == true)
            {
                Itself1.GetComponent<DragLog0>().LogIsOnFire();
                IsFire1 = true;
                Itself2.GetComponent<GlobalFireSpread>().IsFire1 = true;
            }
            if (collision.tag == "FireLog7" && IsFire7 == true)
            {
                Itself1.GetComponent<DragLog0>().LogIsOnFire();
                IsFire1 = true;
                Itself2.GetComponent<GlobalFireSpread>().IsFire1 = true;
            }

            if (collision.tag == "FireLog8" && IsFire8 == true)
            {
                Itself1.GetComponent<DragLog0>().LogIsOnFire();
                IsFire1 = true;
                Itself2.GetComponent<GlobalFireSpread>().IsFire1 = true;
            }
            if (collision.tag == "FireLog9" && IsFire9 == true)
            {
                Itself1.GetComponent<DragLog0>().LogIsOnFire();
                IsFire1 = true;
                Itself2.GetComponent<GlobalFireSpread>().IsFire1 = true;
            }

            if (collision.tag == "FireLog10" && IsFire10 == true)
            {
                Itself1.GetComponent<DragLog0>().LogIsOnFire();
                IsFire1 = true;
                Itself2.GetComponent<GlobalFireSpread>().IsFire1 = true;
            }
            if (collision.tag == "FireLog11" && IsFire11 == true)
            {
                Itself1.GetComponent<DragLog0>().LogIsOnFire();
                IsFire1 = true;
                Itself2.GetComponent<GlobalFireSpread>().IsFire1 = true;
            }

            if (collision.tag == "FireLog12" && IsFire12 == true)
            {
                Itself1.GetComponent<DragLog0>().LogIsOnFire();
                IsFire1 = true;
                Itself2.GetComponent<GlobalFireSpread>().IsFire1 = true;
            }
            if (collision.tag == "FireLog13" && IsFire13 == true)
            {
                Itself1.GetComponent<DragLog0>().LogIsOnFire();
                IsFire1 = true;
                Itself2.GetComponent<GlobalFireSpread>().IsFire1 = true;
            }

            if (collision.tag == "FireLog14" && IsFire14 == true)
            {
                Itself1.GetComponent<DragLog0>().LogIsOnFire();
                IsFire1 = true;
                Itself2.GetComponent<GlobalFireSpread>().IsFire1 = true;
            }
            if (collision.tag == "FireLog15" && IsFire15 == true)
            {
                Itself1.GetComponent<DragLog0>().LogIsOnFire();
                IsFire1 = true;
                Itself2.GetComponent<GlobalFireSpread>().IsFire1 = true;
            }

            if (collision.tag == "FireLog16" && IsFire16 == true)
            {
                Itself1.GetComponent<DragLog0>().LogIsOnFire();
                IsFire1 = true;
                Itself2.GetComponent<GlobalFireSpread>().IsFire1 = true;
            }
            if (collision.tag == "FireLog17" && IsFire17 == true)
            {
                Itself1.GetComponent<DragLog0>().LogIsOnFire();
                IsFire1 = true;
                Itself2.GetComponent<GlobalFireSpread>().IsFire1 = true;
            }

            if (collision.tag == "FireLog18" && IsFire18 == true)
            {
                Itself1.GetComponent<DragLog0>().LogIsOnFire();
                IsFire1 = true;
                Itself2.GetComponent<GlobalFireSpread>().IsFire1 = true;
            }
            if (collision.tag == "FireLog19" && IsFire19 == true)
            {
                Itself1.GetComponent<DragLog0>().LogIsOnFire();
                IsFire1 = true;
                Itself2.GetComponent<GlobalFireSpread>().IsFire1 = true;
            }
            if (collision.tag == "FireLog20" && IsFire20 == true)
            {
                Itself1.GetComponent<DragLog0>().LogIsOnFire();
                IsFire1 = true;
                Itself2.GetComponent<GlobalFireSpread>().IsFire1 = true;
            }
        }
        if (Itself2.tag == "FireLog2" && IsFire2 == false)
        {
            if (collision.tag == "FireLog1" && IsFire1 == true)
            {
                
                Itself2.GetComponent<DragLog1>().LogIsOnFire();
                IsFire2 = true;
                Itself1.GetComponent<GlobalFireSpread>().IsFire2 = true;
            }
            if (collision.tag == "FireLog2(itself)" && IsFire2 == true)
            {
                Itself2.GetComponent<DragLog1>().LogIsOnFire();
                IsFire2 = true;
                Itself1.GetComponent<GlobalFireSpread>().IsFire2 = true;
            }
            if (collision.tag == "FireLog3" && IsFire3 == true)
            {
                Itself2.GetComponent<DragLog1>().LogIsOnFire();
                IsFire2 = true;
                Itself1.GetComponent<GlobalFireSpread>().IsFire2 = true;
            }

            if (collision.tag == "FireLog4" && IsFire4 == true)
            {
                Itself2.GetComponent<DragLog1>().LogIsOnFire();
                IsFire2 = true;
                Itself1.GetComponent<GlobalFireSpread>().IsFire2 = true;
            }
            if (collision.tag == "FireLog5" && IsFire5 == true)
            {
                Itself2.GetComponent<DragLog1>().LogIsOnFire();
                IsFire2 = true;
                Itself1.GetComponent<GlobalFireSpread>().IsFire2 = true;
            }

            if (collision.tag == "FireLog6" && IsFire6 == true)
            {
                Itself2.GetComponent<DragLog1>().LogIsOnFire();
                IsFire2 = true;
                Itself1.GetComponent<GlobalFireSpread>().IsFire2 = true;
            }
            if (collision.tag == "FireLog7" && IsFire7 == true)
            {
                Itself2.GetComponent<DragLog1>().LogIsOnFire();
                IsFire2 = true;
                Itself1.GetComponent<GlobalFireSpread>().IsFire2 = true;
            }

            if (collision.tag == "FireLog8" && IsFire8 == true)
            {
                Itself2.GetComponent<DragLog1>().LogIsOnFire();
                IsFire2 = true;
                Itself1.GetComponent<GlobalFireSpread>().IsFire2 = true;
            }
            if (collision.tag == "FireLog9" && IsFire9 == true)
            {
                Itself2.GetComponent<DragLog1>().LogIsOnFire();
                IsFire2 = true;
                Itself1.GetComponent<GlobalFireSpread>().IsFire2 = true;
            }

            if (collision.tag == "FireLog10" && IsFire10 == true)
            {
                Itself2.GetComponent<DragLog1>().LogIsOnFire();
                IsFire2 = true;
                Itself1.GetComponent<GlobalFireSpread>().IsFire2 = true;
            }
            if (collision.tag == "FireLog11" && IsFire11 == true)
            {
                Itself2.GetComponent<DragLog1>().LogIsOnFire();
                IsFire2 = true;
                Itself1.GetComponent<GlobalFireSpread>().IsFire2 = true;
            }

            if (collision.tag == "FireLog12" && IsFire12 == true)
            {
                Itself2.GetComponent<DragLog1>().LogIsOnFire();
                IsFire2 = true;
                Itself1.GetComponent<GlobalFireSpread>().IsFire2 = true;
            }
            if (collision.tag == "FireLog13" && IsFire13 == true)
            {
                Itself2.GetComponent<DragLog1>().LogIsOnFire();
                IsFire2 = true;
                Itself1.GetComponent<GlobalFireSpread>().IsFire2 = true;
            }

            if (collision.tag == "FireLog14" && IsFire14 == true)
            {
                Itself2.GetComponent<DragLog1>().LogIsOnFire();
                IsFire2 = true;
                Itself1.GetComponent<GlobalFireSpread>().IsFire2 = true;
            }
            if (collision.tag == "FireLog15" && IsFire15 == true)
            {
                Itself2.GetComponent<DragLog1>().LogIsOnFire();
                IsFire2 = true;
                Itself1.GetComponent<GlobalFireSpread>().IsFire2 = true;
            }

            if (collision.tag == "FireLog16" && IsFire16 == true)
            {
                Itself2.GetComponent<DragLog1>().LogIsOnFire();
                IsFire2 = true;
                Itself1.GetComponent<GlobalFireSpread>().IsFire2 = true;
            }
            if (collision.tag == "FireLog17" && IsFire17 == true)
            {
                Itself2.GetComponent<DragLog1>().LogIsOnFire();
                IsFire2 = true;
                Itself1.GetComponent<GlobalFireSpread>().IsFire2 = true;
            }

            if (collision.tag == "FireLog18" && IsFire18 == true)
            {
                Itself2.GetComponent<DragLog1>().LogIsOnFire();
                IsFire2 = true;
                Itself1.GetComponent<GlobalFireSpread>().IsFire2 = true;
            }
            if (collision.tag == "FireLog19" && IsFire19 == true)
            {
                Itself2.GetComponent<DragLog1>().LogIsOnFire();
                IsFire2 = true;
                Itself1.GetComponent<GlobalFireSpread>().IsFire2 = true;
            }
            if (collision.tag == "FireLog20" && IsFire20 == true)
            {
                Itself2.GetComponent<DragLog1>().LogIsOnFire();
                IsFire2 = true;
                Itself1.GetComponent<GlobalFireSpread>().IsFire2 = true;
            }
        }
        if (Itself3.tag == "FireLog3" && IsFire3 == false)
        {
            if (collision.tag == "FireLog1" && IsFire1 == true)
            {

                Itself3.GetComponent<DragLog2>().LogIsOnFire();
                IsFire3 = true;
                
            }
            if (collision.tag == "FireLog2" && IsFire2 == true)
            {
                Itself3.GetComponent<DragLog2>().LogIsOnFire();
                IsFire3 = true;
                
            }
            if (collision.tag == "FireLog3(itself)" && IsFire3 == true)
            {
                Itself3.GetComponent<DragLog2>().LogIsOnFire();
                IsFire3 = true;
                
            }

            
        }
    }
}
