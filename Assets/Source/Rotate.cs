using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Rotate : MonoBehaviour{

    public int speedMultiplier = 1;

    private Vector3 mouseStartingPosition;
    private Vector3 mouseNewPosition;

    public bool rotate = false;

    void Start()
    {

    }
    
	void Update () {

        if (Input.GetMouseButtonDown(1))
            OnInputDown();

        rotate = Input.GetMouseButton(1);

        if (rotate)
        {
            mouseNewPosition = Input.mousePosition;

            Vector3 mouseNewScreen = Camera.main.WorldToViewportPoint(mouseNewPosition);
            Vector3 mouseStartScreen = Camera.main.WorldToViewportPoint(mouseStartingPosition);

            Vector3 dir = mouseNewScreen - mouseStartScreen;

            Vector3 first = transform.position - Camera.main.transform.position;
            Vector3 sec = Vector3.Cross(first, Vector3.up);
            Vector3 third = Vector3.Cross(first, sec);

            transform.Rotate(third, dir.x * speedMultiplier, Space.World);
            transform.Rotate(sec, dir.y * -speedMultiplier, Space.World);
        }
	}

    public void OnInputDown()
    {
        mouseStartingPosition = Input.mousePosition;
        rotate = true;
    }
}
