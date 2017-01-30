using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets;

public class SnappingTool : MonoBehaviour {

    public GameObject top;
    public GameObject left;
    public GameObject right;
    public GameObject bottom;

    float x;
    float y;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void UpdateSnap () {

        x = Input.mousePosition.x;
        y = Input.mousePosition.y;
        if (Input.GetMouseButton(0))
        {
            GameObject[] snaps = GameObject.FindGameObjectsWithTag("Snap");
            foreach (GameObject snap in snaps)
            {
                if (snap != top &&
                    snap != left &&
                    snap != right &&
                    snap != bottom)
                {
                    if (Vector3.Distance(snap.transform.position, transform.position) < 1f)
                    {
                        transform.position = snap.transform.position + snap.transform.localPosition;
                    }
                }
            }
        }
       
	}
    void OnMouseDrag()
    {
        transform.position = Camera.main.ScreenToWorldPoint(new Vector3(x, y, 10.0f));
        UpdateSnap();
    }
}


