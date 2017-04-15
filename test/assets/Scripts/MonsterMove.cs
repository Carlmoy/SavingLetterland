using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterMove : MonoBehaviour {


	private string state= "idle";
	private bool alive = true;
	public Transform CaLePart;
	private UnityEngine.AI.NavMeshAgent nav;


	// Use this for initialization
	void Start () {
		
		if (GetComponent<Rigidbody> ()) {
			GetComponent<Rigidbody> ().freezeRotation = true;
			//
			//CaLePart.GetComponent<ParticleSystem>().emission.enabled=false;
		}
		nav = GetComponent<UnityEngine.AI.NavMeshAgent> ();
		Physics.defaultContactOffset = 0.1F;
	}


	// Update is called once per frame
	void Update () {
		if (alive) 
		{
			if (state == "idle")
			{
				//pick a random place to walk to//
				Vector3 randomPos = Random.insideUnitSphere*50f;
				UnityEngine.AI.NavMeshHit navHit;
				UnityEngine.AI.NavMesh.SamplePosition (transform.position + randomPos, out navHit, 50f, UnityEngine.AI.NavMesh.AllAreas);
				nav.SetDestination (navHit.position);
				state = "walk";
			}

			if (state == "walk") 
			{
				if (nav.remainingDistance <= nav.stoppingDistance && !nav.pathPending) 
				{
					state = "idle";
				}
			}
		}

	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player") {
			//CaLePart.GetComponent<ParticleSystem> ().emission.enabled = true;


			Debug.Log ("BBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBB");
			//StartCoroutine (stopSparkles ());
			//Destroy (other.gameObject);
		}

	}
		/*IEnumerator stopSparkles () 
		{
		yield return new WaitForSeconds (.4f);
		CaLePart.GetComponent<ParticleSystem> ().enableEmission = false;
		}

*/	
}
