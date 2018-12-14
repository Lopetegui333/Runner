using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour {
    Animator Animator;
	// Use this for initialization
	void Start () {
        Animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Animator.SetBool("saltando", true);
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            Animator.SetBool("deslizando", true);
        }
    }
    void RunAgain()
    {
        Animator.SetBool("saltando", false);
    }
    void RunAgainD()
    {

        Animator.SetBool("deslizando", false);

    }
}
