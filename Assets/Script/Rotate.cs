using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Rotate : MonoBehaviour
{
    [Header("REF")]
    public Transform PendulumTrans;

    [Header("SETTINGS")]
    public float RotTime = 0;
    public float RotAngel = 40;
    public float RotSpeed = 2;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        if(PendulumTrans)
        {
            RotTime += Time.deltaTime;
            PendulumTrans.rotation = Quaternion.Euler(0,0, RotAngel *  Mathf.Sin(RotTime*RotSpeed));
        }
    }
}


