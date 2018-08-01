using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserObserver : MonoBehaviour {

    public GameObject other;

    public void OnTriggerEnter(Collider other)
    {
        Animator anim = this.GetComponent<Animator>();
        anim.SetBool("isTargeted", true);
        Debug.Log("Enter");
    }

    public void OnTriggerExit(Collider other)
    {
        Animator anim = this.GetComponent<Animator>();
        anim.SetBool("isTargeted", false);
        Debug.Log("Exit");
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
