using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelsButton : MonoBehaviour {

    public GameObject scrollView;
    public GameObject dental;
    public GameObject multipleDental;

    CameraLookAt camlook;


    void Start()
    {
        camlook = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<CameraLookAt>();
    }

    public void SetState(int state)
    {
        switch (state)
        {
            case 8:
                DisableAll();
                break;
            case 7:
                DisableAll();
                break;
            case 6:
                DisableAll();
                break;
            case 5:
                DisableAll();
                break;
            case 4:
                DisableAll();
                multipleDental.SetActive(true);
                break;
            case 3:
                DisableAll();
                dental.SetActive(true);
                scrollView.SetActive(true);
                break;
            case 2:
                break;
            case 1:
                break;
            default:
                break;
        }
    }


    public void DisableAll()
    {
        camlook.ResetPosition();

        scrollView.SetActive(false);
        dental.SetActive(false);
        multipleDental.SetActive(false);
    }
}
