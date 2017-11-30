using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tooth : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
    }

    void OnMouseDown()
    {
        Camera.main.GetComponent<CameraLookAt>().SetTarget(this.transform);
    }
}
