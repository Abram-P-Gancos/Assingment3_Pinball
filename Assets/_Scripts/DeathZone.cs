using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZone : MonoBehaviour
{
    private GameManager manager;

    private void Start()
    {
        manager = GameObject.FindObjectOfType<GameManager>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.CompareTag("PlayerBall"))
        { 
            //destroy the ball
            Destroy(other.gameObject);

            //tell gamemanger the ball was destroyed
            manager.EndBall();
            
        }
    }
}
