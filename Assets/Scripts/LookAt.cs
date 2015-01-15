using UnityEngine;
using System.Collections;

public class LookAt : MonoBehaviour {

    public Transform playerTransform;
	
	// Update is called once per frame
	void Update () {
        transform.LookAt(playerTransform);
        UsefulFunctions.DebugRay(transform.position, transform.forward * 100, Color.green);
	}
}
