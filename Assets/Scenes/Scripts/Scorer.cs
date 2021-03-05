using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int score = 0;

    private void OnCollisionEnter(Collision obstacle)
    {
        if (obstacle.gameObject.tag != "Hit")
        {
            score++;
            Debug.Log($"bumping into something {score}");
        }
    }
}
