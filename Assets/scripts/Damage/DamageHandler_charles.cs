using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageHandler_charles : MonoBehaviour
{
    public int health = 100;
    public AudioClip deathClip;


    private void OnTriggerEnter2D()
    {
        Debug.Log("Trigger charles");
        health -= 10;
    }

    private void Update()
    {
        if (health <= 0)
        {
            AudioSource.PlayClipAtPoint(deathClip, transform.position);
            die();
        }
    }
    void die()
    {
        Destroy(gameObject);
    }
}
