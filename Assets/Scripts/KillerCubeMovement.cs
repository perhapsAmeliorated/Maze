using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillerCubeMovement : MonoBehaviour
{
    public GameObject player;
    public float killerSpeed = 3.3f;
    public Vector3 offset = new Vector3(4, 6, 0);
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + offset;
    }
}
