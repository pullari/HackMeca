using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.UIElements;
using UnityEngine.UI;

public class CameraLookAt : MonoBehaviour
{
    public UnityEngine.UI.Image[] popups;
    public ScrollView hideable;
    public Transform target;
    private Vector3 originalPosition;
    private Quaternion originalRotation;
    private Quaternion zoomRot;

    public float zoomDist = -35;
    private float t = 0;
    public float zoomSpeed = 5;

    private bool zoomed = false;

    private void Start()
    {
        originalPosition = transform.position;
        originalRotation = transform.rotation;
    }

    void Update()
    {
        if (zoomed)
        {
            if(transform.position.z < zoomDist)
            {
                t += zoomSpeed * Time.deltaTime;
                transform.position = Vector3.Lerp(originalPosition, new Vector3(transform.position.x, transform.position.y, zoomDist), t);
            }
            transform.LookAt(target);
        } else if (transform.position.z > originalPosition.z)
        {
            t += zoomSpeed * Time.deltaTime;
            transform.position = Vector3.Lerp(new Vector3(transform.position.x, transform.position.y, zoomDist), originalPosition, t);
            transform.rotation = Quaternion.Lerp(zoomRot, originalRotation, t);
            if (t >= 1)
                t = 0;
        }

        if (Input.GetMouseButtonDown(1) && zoomed)
            ResetPosition();
    }

    public void ResetPosition()
    {
        zoomRot = transform.rotation;
        t = 0;
        zoomed = false;
    }

    public void SetTarget(Transform t)
    {
        if (!zoomed)
        {
            target.position = new Vector3(t.position.x + 10, t.position.y + 3, t.position.z);
            zoomed = true;

        }
        else
            ResetPosition();
    }
}

