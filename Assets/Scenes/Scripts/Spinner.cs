using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float xRotation = 0f;
    [SerializeField] float yRotation = 0.35f;
    [SerializeField] float zRotation = 0f;


    void Update()
    {
        transform.Rotate(xRotation, yRotation, zRotation);
    }
}
