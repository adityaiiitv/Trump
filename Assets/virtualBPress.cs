using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
public class virtualBPress : MonoBehaviour, IVirtualButtonEventHandler {

    public GameObject vb,vb1,vb2,vb3;
    public GameObject zombie;
    public void OnButtonPressed(VirtualButtonAbstractBehaviour vb)
    {
        zombie.GetComponent<Animation>().Play();
    }

    public void OnButtonReleased(VirtualButtonAbstractBehaviour vb)
    {
        zombie.GetComponent<Animation>().Stop();
    }

    // Use this for initialization
    void Start () {
        vb = GameObject.Find("action");
        vb.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        vb1 = GameObject.Find("action1");
        vb1.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        vb2 = GameObject.Find("action2");
        vb2.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        vb3 = GameObject.Find("action3");
        vb3.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        zombie = GameObject.Find("zombie");
	}
}
