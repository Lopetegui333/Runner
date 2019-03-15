using UnityEngine;

public class Movimiennto : MonoBehaviour
{
    public float thrust;
    public Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        //  rb = GetComponent<Rigidbody>();
        // rb.AddForce(transform.forward * thrust);
        
    }

    void Update()
    {
        rb.velocity = new Vector3(0, 0, 10);
    }
   
}