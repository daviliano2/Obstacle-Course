using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float movementSpeed = 2f;

    // Start is called before the first frame update
    void Start()
    { }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * movementSpeed * Time.deltaTime;
        float zValue = Input.GetAxis("Vertical") * movementSpeed * Time.deltaTime;
        transform.Translate(xValue, 0f, zValue);
    }
}
