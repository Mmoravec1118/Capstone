using Assets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Snap : MonoBehaviour {
    public Constants.SnapSide snapSide;
    bool locked = false;
    Snap connectedTo;
    public bool Locked
    {
        get { return locked; }
        set { locked = value; }
    }

    public Snap ConnectedTo
    {
        get { return connectedTo; }
        set { connectedTo = value; }
    }
	// Use this for initialization
	
}
