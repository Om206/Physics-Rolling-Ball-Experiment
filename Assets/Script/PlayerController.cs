using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    
    public Rigidbody rb;
    
    public float moveSpeed = 10f;
    private float xInput;
    private float zInput;
    //public Transform Target;
    void Awake()
    {
        
        rb = GetComponent<Rigidbody>();
        //print(a);
    }

    // Update is called once per frame
    void Update()
    {
        
        ProcessInputs();
    }

    private void FixedUpdate()
    {
        //transform.position = Target.position;
        Move();
    }

    private void ProcessInputs()
    {
        
        xInput = Input.GetAxis("Horizontal");
        zInput = Input.GetAxis("Vertical");
        
    }

    private void Move()
    {
        rb.AddForce(new Vector3(xInput, 0f, zInput) * moveSpeed);
    }
}
