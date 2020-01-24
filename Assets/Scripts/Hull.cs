﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hull : MonoBehaviour
{
    private PlayerController pController;
    private Vector3 initVel;
    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        pController = GameObject.Find("Player").GetComponent<PlayerController>();
    }
    void Start()
    {
        initVel = rb.velocity + Vector3.back * 6f;
    }
    void Update()
    {
        if (pController.Velocity > .9f)
            rb.velocity = initVel;
        else
            initVel = rb.velocity + Vector3.back * 6f;
    }
}
