#pragma strict


var stw:float = 10;
var heiClip:AudioClip;
function OnTriggerExit(o:Collider) {
    Debug.Log("Toimii");
    
    GetComponent.<AudioSource>().PlayOneShot(heiClip);
    yield WaitForSeconds (heiClip.length);
    GetComponent.<AudioSource>().enabled = false;
    yield WaitForSeconds (stw);
    GetComponent.<AudioSource>().enabled = true;
        
    
}