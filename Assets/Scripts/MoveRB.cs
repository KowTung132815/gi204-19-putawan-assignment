using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRB : MonoBehaviour
{
    private float horizontaIIput;
    private float verticaIInput;
    private Rigidbody myRb;
    private float speed = 10.0f;
    private Vector3 movePosition;
    void Start()
    {
        myRb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        myRb.MovePosition(myRb.position + movePosition * speed * Time.fixedTime);
    }

    // Update is called once per frame
    void Update()
    {
        horizontaIIput = Input.GetAxis("Horizontal");
        verticaIInput = Input.GetAxis("Vertical");
        movePosition = new Vector3(horizontaIIput, 0, verticaIInput);
    }
}
