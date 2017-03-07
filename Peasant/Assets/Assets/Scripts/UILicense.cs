using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UILicense : MonoBehaviour {
    bool growDone = false;
	// Use this for initialization
	void Start () {
        StartCoroutine("Grow");
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0) && growDone)
        {
            Destroy(gameObject);
        }
	}

    IEnumerator Grow()
    {
        for (int i = 0; i < 100; i++)
        {
            GetComponent<RectTransform>().localScale += new Vector3(.01f,.01f);
            yield return null;
        }
        growDone = true;
    }
}
