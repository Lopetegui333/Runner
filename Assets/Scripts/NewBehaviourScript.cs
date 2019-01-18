using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {
    public GameObject izqd;
    public GameObject der;
    public GameObject mid;
    Rigidbody Rigidbody1;
    Vector3 myVector;
    public Vector3 target;
    public float speed;
    // Use this for initialization
    void Start () {

        float speed = 100 ;
        myVector = mid.transform.position;  
    }
	
	// Update is called once per frame
	void Update () {

        

        if (Input.GetKeyDown(KeyCode.A) && (transform.position.x == mid.transform.position.x))
        {
            target = myVector;
            myVector = new Vector3(izqd.transform.position.x, izqd.transform.position.y, transform.position.z);
            
                  }
        if (Input.GetKeyDown(KeyCode.D) && (transform.position.x == mid.transform.position.x))
        {
            
            myVector = new Vector3(der.transform.position.x, der.transform.position.y, transform.position.z);
            
        }
        if (Input.GetKeyDown(KeyCode.D) && (transform.position.x == izqd.transform.position.x))
        {
            
            myVector = new Vector3(mid.transform.position.x, mid.transform.position.y, transform.position.z);
            
        }
        if (Input.GetKeyDown(KeyCode.A) && (transform.position.x == der.transform.position.x))
        {
            myVector = new Vector3(mid.transform.position.x, mid.transform.position.y, transform.position.z);
            
        }
        transform.position = Vector3.MoveTowards(transform.position, myVector, speed);
    }

}

