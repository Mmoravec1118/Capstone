using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class BowPickup : MonoBehaviour {
    public GameObject playerBow;
    public FirstPersonController player; 
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void Action()
    {
        gameObject.SetActive(false);
        playerBow.SetActive(true);
        player.hasBow = true;
        player.animator.SetTrigger("Pickup");
    }
}
