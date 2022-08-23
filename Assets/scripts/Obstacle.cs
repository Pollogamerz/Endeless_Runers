using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    Mov playerMovement;

    void Start()
    {
        playerMovement = GameObject.FindObjectOfType<Mov>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player");
        {
            playerMovement.Die();
        }
    }

    void Update()
    {
        
    }
}
