﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour 
{
    public float speed;

    void Start()
    {
        this.gameObject.GetComponent<Rigidbody>().velocity = transform.forward * speed;
    }
}
