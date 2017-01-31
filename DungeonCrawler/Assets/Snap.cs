using Assets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Snap : MonoBehaviour {
    public Constants.SnapSide snapSide;
    bool locked = false;

    public bool Locked
    {
        get { return locked; }
        set { locked = value; }
    }
	// Use this for initialization
	
}
