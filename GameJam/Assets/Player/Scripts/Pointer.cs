using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pointer : MonoBehaviour {

    public int range;
    public Camera cam;
    public GameObject bulletParent;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Ray ray = new Ray(cam.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, 0.0f)), cam.transform.forward);
        RaycastHit hit;
        Debug.DrawRay(ray.origin, ray.direction * range, Color.green);

        if (Physics.Raycast(ray, out hit, range))
        {
            
        }
    }
}
