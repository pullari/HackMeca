using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelsButton : MonoBehaviour {

    public GameObject scrollView;
    public GameObject dental;
    public GameObject multipleDental;
    public GameObject popup;
    public GameObject popup2;
    public GameObject popup3;
    public GameObject historiikki;
    public GameObject dataUI;
    public GameObject ThreeDeeData;
    public GameObject Wearabledata;

    CameraLookAt camlook;


    void Start()
    {
        camlook = Camera.main.GetComponent<CameraLookAt>();
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
                dental.SetActive(true);
                Wearabledata.SetActive(true);
                break;
            case 6:
                DisableAll();
                break;
            case 5:
                DisableAll();
                scrollView.SetActive(true);
                dental.SetActive(true);
                historiikki.SetActive(true);
                break;
            case 4:
                DisableAll();
                multipleDental.SetActive(true);
                ThreeDeeData.SetActive(true);
                scrollView.SetActive(true);
                break;
            case 3:
                DisableAll();
                dental.SetActive(true);
                scrollView.SetActive(true);
                dataUI.SetActive(true);
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

        multipleDental.SetActive(false);
        popup.SetActive(false);
        popup2.SetActive(false);
        popup3.SetActive(false);
        historiikki.SetActive(false);
        dataUI.SetActive(false);
        ThreeDeeData.SetActive(false);
        scrollView.SetActive(false);
        dental.SetActive(false);
        Wearabledata.SetActive(false);
    }
}
