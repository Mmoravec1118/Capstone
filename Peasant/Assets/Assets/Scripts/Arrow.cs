using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour {

	// Use this for initialization
	void Start () {
       GetComponent<Rigidbody>().AddForce(Camera.main.transform.forward, ForceMode.Impulse);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
