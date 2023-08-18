using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

<<<<<<<< HEAD:Assets/Scripts/KillerCubeMovement.cs
public class KillerCubeMovement : MonoBehaviour
========
public class CubeFollow : MonoBehaviour
>>>>>>>> pr/2:Assets/CubeFollow.cs
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
