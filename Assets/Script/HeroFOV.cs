using UnityEngine;
using System.Collections;

public class HeroFOV : MonoBehaviour {

    public GameObject hero;
    UnityEngine.AI.NavMeshAgent agent;

	// Use this for initialization
	void Start () {
        agent = hero.GetComponent<UnityEngine.AI.NavMeshAgent>();
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = hero.transform.position;
        transform.rotation = Quaternion.LookRotation(agent.velocity);
    }
}
