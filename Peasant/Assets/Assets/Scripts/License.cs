using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class License : MonoBehaviour {
    [SerializeField]
    GameObject UILicense;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void Action()
    {
        Destroy(gameObject);
        UILicense.SetActive(true);
    }
}
