#pragma strict

var heiClip:AudioClip;
function OnTriggerEnter(o:Collider) {
    Debug.Log("Toimii");
    yield WaitForSeconds(0.25);
    GetComponent.<AudioSource>().PlayOneShot(heiClip);
    yield WaitForSeconds(1);
    

}

