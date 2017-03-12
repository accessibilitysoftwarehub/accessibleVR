using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reticle : MonoBehaviour {

    public Camera cameraFacing;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.LookAt(cameraFacing.transform.position);
        transform.position = cameraFacing.transform.position + cameraFacing.transform.rotation * Vector3.forward * 2;
        transform.Rotate(0.0f, 180.0f, 0.0f);
    }
}
