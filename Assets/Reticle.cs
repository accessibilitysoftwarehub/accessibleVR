using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reticle : MonoBehaviour {

    public Camera cameraFacing;
    private Vector3 originalScale;
	// Use this for initialization
	void Start () {
        originalScale = transform.localScale;
	}
	
	// Update is called once per frame
	void Update () {

        RaycastHit hit;
        float distance;
        if (Physics.Raycast (new Ray(cameraFacing.transform.position, cameraFacing.transform.rotation * Vector3.forward), out hit))
        {
            distance = hit.distance;
        }
        else
        {
            distance = cameraFacing.farClipPlane * 0.95f;
        }

        transform.LookAt(cameraFacing.transform.position);
        transform.position = cameraFacing.transform.position + cameraFacing.transform.rotation * Vector3.forward * distance;
        transform.Rotate(0.0f, 180.0f, 0.0f);
        transform.localScale = originalScale * distance;
    }
}
