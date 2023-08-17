using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    public float moveSpeed = 5.0f; // Adjust the move speed to your preference

    void Start()
    {
       // rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {

    }
}