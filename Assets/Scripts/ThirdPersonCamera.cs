﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCamera : MonoBehaviour
{
    public Transform lookAt;
    public Transform camTransform;

    private Camera cam;

    private float distance = 10.0f;
    private float currentX = 0.0f;
    private float currentY = 0.0f;
    private float sensivityX = 4.0f;
    private float sensivityY = 1.0f;


    // Start is called before the first frame update
    void Start()
    {
        camTransform = transform;
        cam = Camera.main;
    }

    // Update is called once per frame
    void LateUpdate()
    {
       // Vector3 dir = new Vector3(0,0,-distance);
        //Quaternion rotation; //= Quaternion.Euler(currentY, currentX, 0);
        //camTransform.position = lookAt.position + rotation * dir;
        camTransform.LookAt(lookAt.position);
    }
}