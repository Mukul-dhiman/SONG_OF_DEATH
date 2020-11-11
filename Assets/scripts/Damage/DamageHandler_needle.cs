using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageHandler_needle : MonoBehaviour
{
    public int health = 15;


    private void OnTriggerEnter2D()
    {
        Debug.Log("Trigger needle");
        health -= 10;
    }

    private void Update()
    {
        if(health <= 0)
        {
            die();
        }
    }
    void die()
    {
        Destroy(gameObject);
    }
}
