using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float timeToWait = 3f;

    MeshRenderer obstacleRenderer;
    Rigidbody obstacleRigidbody;
    // Start is called before the first frame update
    void Start()
    {
        obstacleRenderer = GetComponent<MeshRenderer>();
        obstacleRigidbody = GetComponent<Rigidbody>();

        obstacleRenderer.enabled = false;
        obstacleRigidbody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > timeToWait)
        {
            Debug.Log("3 seconds have past");
            obstacleRenderer.enabled = true;
            obstacleRigidbody.useGravity = true;
        }
    }
}
