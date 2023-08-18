using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CubeFollow : MonoBehaviour

{
    public NavMeshAgent KillerCube;
    public Transform player;

    public float killerSpeed = 3.3f;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        KillerCube.SetDestination(player.position);
    }
}