using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ryzen3 : MonoBehaviour, IVirtualButtonEventHandler
{
    public GameObject amd3, box3, suara3;
    public Animator animasi3, animasibox3;
    // Start is called before the first frame update
    void Start()
    {
        animasi3 = GetComponent<Animator>();
        VirtualButtonBehaviour[] vrb = GetComponentsInChildren<VirtualButtonBehaviour>();
        for (int i = 0; i < vrb.Length; i++)
        {
            vrb[i].RegisterEventHandler(this);
        }

        amd3.SetActive(true);
        box3.SetActive(false);
        suara3.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        if (vb.VirtualButtonName == "vb1")
        {
            Debug.Log("Developer Button Pressed");
            amd3.SetActive(false);
            box3.SetActive(true);
            suara3.SetActive(false);
            box3.GetComponent<Animator>().Play("Box3");
        }
        else if (vb.VirtualButtonName == "vb2")
        {
            Debug.Log("Developer Button Pressed");
            amd3.SetActive(true);
            box3.SetActive(false);
            suara3.SetActive(false);
            amd3.GetComponent<Animator>().Play("ryzen3");

        }
        else if (vb.VirtualButtonName == "vb3")
        {
            Debug.Log("Developer Button Pressed");
            amd3.SetActive(true);
            box3.SetActive(false);
            suara3.SetActive(true);
        }
        else
        {
            throw new UnityException(vb.VirtualButtonName + "Virtual Button not Supoortd");
        }
    }
    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        if (vb.VirtualButtonName == "vb1")
        {
            Debug.Log("Developer Button Released");
            amd3.SetActive(true);
            box3.SetActive(false);
            suara3.SetActive(false);
            box3.GetComponent<Animator>().Play("Box3normal");
        }
        else if (vb.VirtualButtonName == "vb2")
        {
            Debug.Log("Developer Button Released");
            amd3.SetActive(true);
            box3.SetActive(false);
            suara3.SetActive(false);
            amd3.GetComponent<Animator>().Play("ryzen3normal");

        }
        else if (vb.VirtualButtonName == "vb3")
        {
            Debug.Log("Developer Button Released");
            amd3.SetActive(true);
            box3.SetActive(false);
            suara3.SetActive(false);
        }
        else
        {
            throw new UnityException(vb.VirtualButtonName + "Virtual Button not Supoortd");
        }
    }
}