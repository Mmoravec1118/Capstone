using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class WraithNavigation : MonoBehaviour {
    NavMeshAgent nav;
    public Transform target;
	// Use this for initialization
	void Start () {
        nav = GetComponent<NavMeshAgent>();
        nav.destination = target.position;
	}
	
	// Update is called once per frame
	void Update () {
        nav.destination = target.position;

    }
}
