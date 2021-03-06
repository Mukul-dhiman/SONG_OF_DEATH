﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damage_handler : MonoBehaviour
{
    public int health = 10;
    public AudioClip deathClip;

    private void OnTriggerEnter2D()
    {
        Debug.Log("Trigger needle");
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
