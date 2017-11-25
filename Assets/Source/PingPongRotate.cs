using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PingPongRotate : MonoBehaviour {
    public float speed = 10;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 rot = transform.eulerAngles;
        transform.eulerAngles = new Vector3(rot.x, -5 + Mathf.PingPong(Time.time * speed, 85), rot.z);
    }
}
