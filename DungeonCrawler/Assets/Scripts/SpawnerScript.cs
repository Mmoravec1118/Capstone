using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour {

    public GameObject toDuplicate;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void OnMouseDown()
    {
        GameObject obj = GameObject.Instantiate(toDuplicate, transform.position, new Quaternion(), gameObject.transform.parent) as GameObject;
        obj.GetComponent<SnappingTool>().beingDragged = true;
    }
}
