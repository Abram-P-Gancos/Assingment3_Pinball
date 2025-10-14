using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int lives = 5;
    public GameObject ballPrefab;
    public Transform ballStart;

    public void EndBall()
    {
        lives--;
        if(lives == 0 )
        {
            //show the games over
        }
        else
        {
            //instantiate a new ball at the player position
            Instantiate(ballPrefab, ballStart.position, Quaternion.identity);
        }
    }
}
