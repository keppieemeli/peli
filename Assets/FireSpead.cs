using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FireSpead : MonoBehaviour {


    public GameObject NewActualFire;
    public GameObject gameObject2;
    private DragRig222 DragRig22Script;


    // Use this for initialization
    void Start () {
        DragRig22Script = base.gameObject.GetComponent<DragRig222>();
        
	}
	
	// Update is called once per frame
	void Update () {
        
        if(gameObject2.GetComponent<DragRig222>().enabled == true)
        {
            
            
            DragRig22Script.FireLogText2.SetActive(true);
        }
    }
    
    public void Access()
    {
        DragRig22Script.enabled = false;
        
        StartCoroutine(RealBurn());
    }
    public IEnumerator RealBurn()
    {
        
        gameObject2.GetComponent<DragRig222>().ActualFire.SetActive(false);
        NewActualFire.SetActive(true);
        //gameObject2.GetComponent<DragRig222>().
        yield return new WaitForSeconds(30);
        Debug.Log("Wooden Log Burn Out");
        gameObject2.SetActive(false);
    }
    public void OnTriggerStay(Collider other)
    {
        if (other.transform.tag == "FireLog")
        {
            if(other.gameObject.GetComponent<DragRig222>().isFireTrue == true)
            {
                gameObject2.GetComponent<DragRig222>().FireLogText2.SetActive(false);

                gameObject2.GetComponent<DragRig222>().isFireTrue = true;
                gameObject2.GetComponent<DragRig222>().enabled = false;
                
                StartCoroutine(RealBurn());
                
               
            }
        }
    }
}
