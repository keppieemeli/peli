using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour {
    public float LookRadius = 10f;
    Transform target;
    public AudioSource MurrSource;
    public AudioClip MurrClip;
    NavMeshAgent agent;
    

    // Use this for initialization
    public void Start () {
        target = PlayerManager.instance.player.transform;
        agent = GetComponent<NavMeshAgent>();
        
    }



    IEnumerator Murr()
    {
        
        
        
        yield return new WaitWhile(() => MurrSource.isPlaying);

        gameObject.GetComponent<AudioSource>().PlayOneShot(MurrClip);

        yield return new WaitForSeconds(1);


    }

	// Update is called once per frame
	public void Update () {
        
        float distance = Vector3.Distance(target.position, transform.position);
        if(distance <= LookRadius)
        {
            StartCoroutine(Murr());

            agent.SetDestination(target.position);
            
            if (distance <= agent.stoppingDistance)
            {
                FaceTarget();
                
            }
        }
        else
        {
            StopCoroutine(Murr());
        }
	}
    void FaceTarget()
    {
        Vector3 direction = (target.position - transform.position).normalized;
        Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * 5f);

        //Smoothing!!!
        //Smoothing!!!

    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, LookRadius);
    }



}
