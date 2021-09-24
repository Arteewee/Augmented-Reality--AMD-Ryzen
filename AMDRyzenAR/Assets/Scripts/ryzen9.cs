using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ryzen9 : MonoBehaviour, IVirtualButtonEventHandler
{
    public GameObject amd9, box9, suara9;
    public Animator animasi9, animasibox9;
    // Start is called before the first frame update
    void Start()
    {
        animasi9 = GetComponent<Animator>();
        VirtualButtonBehaviour[] vrb = GetComponentsInChildren<VirtualButtonBehaviour>();
        for (int i = 0; i < vrb.Length; i++)
        {
            vrb[i].RegisterEventHandler(this);
        }

        amd9.SetActive(true);
        box9.SetActive(false);
        suara9.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        if (vb.VirtualButtonName == "vb91")
        {
            Debug.Log("Developer Button Pressed");
            amd9.SetActive(false);
            box9.SetActive(true);
            suara9.SetActive(false);
            box9.GetComponent<Animator>().Play("Box9");
        }
        else if (vb.VirtualButtonName == "vb92")
        {
            Debug.Log("Developer Button Pressed");
            amd9.SetActive(true);
            box9.SetActive(false);
            suara9.SetActive(false);
            amd9.GetComponent<Animator>().Play("ryzen9");

        }
        else if (vb.VirtualButtonName == "vb93")
        {
            Debug.Log("Developer Button Pressed");
            amd9.SetActive(true);
            box9.SetActive(false);
            suara9.SetActive(true);
        }
        else
        {
            throw new UnityException(vb.VirtualButtonName + "Virtual Button not Supoortd");
        }
    }
    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        if (vb.VirtualButtonName == "vb91")
        {
            Debug.Log("Developer Button Released");
            amd9.SetActive(true);
            box9.SetActive(false);
            suara9.SetActive(false);
            box9.GetComponent<Animator>().Play("Box9normal");
        }
        else if (vb.VirtualButtonName == "vb92")
        {
            Debug.Log("Developer Button Released");
            amd9.SetActive(true);
            box9.SetActive(false);
            suara9.SetActive(false);
            amd9.GetComponent<Animator>().Play("ryzen9normal");

        }
        else if (vb.VirtualButtonName == "vb93")
        {
            Debug.Log("Developer Button Released");
            amd9.SetActive(true);
            box9.SetActive(false);
            suara9.SetActive(false);
        }
        else
        {
            throw new UnityException(vb.VirtualButtonName + "Virtual Button not Supoortd");
        }
    }
}