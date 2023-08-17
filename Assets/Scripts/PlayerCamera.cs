using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    public GameObject player;
    Vector3 offset = new Vector3(0, 0, 0);

    private float rotationX = 0.0f;
    private float rotationY = 0.0f;
    public float mouseSensitivity = 5.0f;

    // Update is called once per frame
    void Update()
    {
        //positions camera to follow player with modifiable offset
        transform.position = player.transform.position + offset;
        //Makes camera move with mouse
        rotationY += Input.GetAxis("Mouse X") * mouseSensitivity;
        rotationX += Input.GetAxis("Mouse Y") * -1 * mouseSensitivity;
        transform.localEulerAngles = new Vector3(rotationX, rotationY, 0);
    }
}
