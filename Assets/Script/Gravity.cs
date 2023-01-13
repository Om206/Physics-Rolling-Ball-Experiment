using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{

    public float value;
    public GameObject x;
    void Start()
    {
        Physics.gravity = new Vector3(0,value,0);
    }

    // Update is called once per frame
    void Update()
    {
        Physics.gravity = new Vector3(0,value,0);
    }
}
