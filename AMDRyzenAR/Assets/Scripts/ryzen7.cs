using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ryzen7 : MonoBehaviour, IVirtualButtonEventHandler
{
    public GameObject amd7, box7, suara7;
    public Animator animasi7, animasibox7;
    // Start is called before the first frame update
    void Start()
    {
        animasi7 = GetComponent<Animator>();
        VirtualButtonBehaviour[] vrb = GetComponentsInChildren<VirtualButtonBehaviour>();
        for (int i = 0; i < vrb.Length; i++)
        {
            vrb[i].RegisterEventHandler(this);
        }

        amd7.SetActive(true);
        box7.SetActive(false);
        suara7.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        if (vb.VirtualButtonName == "vb71")
        {
            Debug.Log("Developer Button Pressed");
            amd7.SetActive(false);
            box7.SetActive(true);
            suara7.SetActive(false);
            box7.GetComponent<Animator>().Play("Box7");
        }
        else if (vb.VirtualButtonName == "vb72")
        {
            Debug.Log("Developer Button Pressed");
            amd7.SetActive(true);
            box7.SetActive(false);
            suara7.SetActive(false);
            amd7.GetComponent<Animator>().Play("Ryzen7");

        }
        else if (vb.VirtualButtonName == "vb73")
        {
            Debug.Log("Developer Button Pressed");
            amd7.SetActive(true);
            box7.SetActive(false);
            suara7.SetActive(true);
        }
        else
        {
            throw new UnityException(vb.VirtualButtonName + "Virtual Button not Supoortd");
        }
    }
    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        if (vb.VirtualButtonName == "vb71")
        {
            Debug.Log("Developer Button Released");
            amd7.SetActive(true);
            box7.SetActive(false);
            suara7.SetActive(false);
            box7.GetComponent<Animator>().Play("Box7normal");
        }
        else if (vb.VirtualButtonName == "vb72")
        {
            Debug.Log("Developer Button Released");
            amd7.SetActive(true);
            box7.SetActive(false);
            suara7.SetActive(false);
            amd7.GetComponent<Animator>().Play("normal7");

        }
        else if (vb.VirtualButtonName == "vb73")
        {
            Debug.Log("Developer Button Released");
            amd7.SetActive(true);
            box7.SetActive(false);
            suara7.SetActive(false);
        }
        else
        {
            throw new UnityException(vb.VirtualButtonName + "Virtual Button not Supoortd");
        }
    }
}
