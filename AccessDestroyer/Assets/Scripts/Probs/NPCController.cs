using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCController : MonoBehaviour {

    private Rigidbody2D rbody;
    // Use this for initialization
	void Start () {

        rbody = this.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        if (rbody.isKinematic == true)
        {
            rbody.isKinematic = false;
        }
    }

}
