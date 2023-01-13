using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resetPosition : MonoBehaviour
{

    [SerializeField] KeyCode _keyCode;
    
    
    //[SerializeField] UnityEvent _event;
    public GameObject b1;
    public GameObject b2;

    private Vector3 a;
    private Vector3 b;
    void Start()
    {
        a = b1.transform.position;
        b = b2.transform.position;
        print(a);
        print(b);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(_keyCode))
        {
            print("pressed");
          b1.transform.position = a;
          b2.transform.position = b;
            
        }
    }
}
