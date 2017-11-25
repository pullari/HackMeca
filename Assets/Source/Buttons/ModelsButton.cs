using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelsButton : MonoBehaviour {

    public GameObject scrollView;
    public GameObject dental;
    public GameObject multipleDental;


    public void SetState(int state)
    {
        switch (state)
        {
            case 8:
                print("Why hello there good sir! Let me teach you about Trigonometry!");
                break;
            case 7:
                print("Why hello there good sir! Let me teach you about Trigonometry!");
                break;
            case 6:
                print("Why hello there good sir! Let me teach you about Trigonometry!");
                break;
            case 5:
                print("Why hello there good sir! Let me teach you about Trigonometry!");
                break;
            case 4:
                print("Hello and good day!");
                break;
            case 3:
                DisableAll();

                print("Whadya want?");
                break;
            case 2:
                print("Grog SMASH!");
                break;
            case 1:
                print("Ulg, glib, Pblblblblb");
                break;
            default:
                print("Incorrect intelligence level.");
                break;
        }
    }


    public void DisableAll()
    {
        scrollView.SetActive(false);
        dental.SetActive(false);
        multipleDental.SetActive(false);
    }
}
