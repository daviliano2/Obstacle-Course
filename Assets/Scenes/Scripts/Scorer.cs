using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int score = 0;

    private void OnCollisionEnter(Collision obstacle)
    {
        Debug.Log($"bumping into something {score++}");
    }
}
