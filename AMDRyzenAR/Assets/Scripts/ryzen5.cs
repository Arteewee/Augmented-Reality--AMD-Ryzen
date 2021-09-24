using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ryzen5 : MonoBehaviour, IVirtualButtonEventHandler
{
    public GameObject amd5, box5, suara5;
    public Animator animasi5,animasibox5;
    // Start is called before the first frame update
    void Start()
    {
        animasi5 = GetComponent<Animator>();
        VirtualButtonBehaviour[] vrb = GetComponentsInChildren<VirtualButtonBehaviour>();
        for (int i = 0; i < vrb.Length; i++)
        {
            vrb[i].RegisterEventHandler(this);
        }

        amd5.SetActive(true);
        box5.SetActive(false);
        suara5.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        if (vb.VirtualButtonName == "vb51")
        {
            Debug.Log("Developer Button Pressed");
            amd5.SetActive(false);
            box5.SetActive(true);
            suara5.SetActive(false);
            box5.GetComponent<Animator>().Play("Box5");
        }
        else if (vb.VirtualButtonName == "vb52")
        {
            Debug.Log("Developer Button Pressed");
            amd5.SetActive(true);
            box5.SetActive(false);
            suara5.SetActive(false);
            amd5.GetComponent<Animator>().Play("ryzen5");
            
        }
        else if (vb.VirtualButtonName == "vb53")
        {
            Debug.Log("Developer Button Pressed");
            amd5.SetActive(true);
            box5.SetActive(false);
            suara5.SetActive(true);
        }
        else
        {
            throw new UnityException(vb.VirtualButtonName + "Virtual Button not Supoortd");
        }
    }
    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        if (vb.VirtualButtonName == "vb51")
        {
            Debug.Log("Developer Button Released");
            amd5.SetActive(true);
            box5.SetActive(false);
            suara5.SetActive(false);
            box5.GetComponent<Animator>().Play("Box5normal");
        }
        else if (vb.VirtualButtonName == "vb52")
        {
            Debug.Log("Developer Button Released");
            amd5.SetActive(true);
            box5.SetActive(false);
            suara5.SetActive(false);
            amd5.GetComponent<Animator>().Play("normal5");
           
        }
        else if (vb.VirtualButtonName == "vb53")
        {
            Debug.Log("Developer Button Released");
            amd5.SetActive(true);
            box5.SetActive(false);
            suara5.SetActive(false);
        }
        else
        {
            throw new UnityException(vb.VirtualButtonName + "Virtual Button not Supoortd");
        }
    }
}
