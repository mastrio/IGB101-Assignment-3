using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeRotator : MonoBehaviour
{
    public float rotationSpeed = 30f; // Adjust this value to control the rotation speed

    void Update()
    {
        // Rotate the cube around its local Y-axis
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    }
}

