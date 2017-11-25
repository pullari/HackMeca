using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleActive : MonoBehaviour {

    public void activation()
    {
        gameObject.SetActive(!gameObject.activeSelf);
    }
}
