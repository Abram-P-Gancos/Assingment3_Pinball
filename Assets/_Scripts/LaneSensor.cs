using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaneSencor : MonoBehaviour
{
    public int points = 50;
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.CompareTag("PlayerBall"))
        {
            ScoreManager.AddScore(points);
        }
    }
}
