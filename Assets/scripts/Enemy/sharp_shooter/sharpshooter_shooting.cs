﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sharpshooter_shooting : MonoBehaviour
{
    private AudioSource shot_audio;
    public GameObject bullet_copy;
    public float fireDelay = 3f;
    float coolDownTime = 0;
    float ship_radius = 0.5f;

    Transform player;

    private void Start()
    {
        shot_audio = GetComponent<AudioSource>();
    }

    bool allow_to_shoot = true;

    void Update()
    {
        if (player == null)
        {

            GameObject go = GameObject.FindWithTag("Player");
            if (go != null)
            {
                player = go.transform;
            }
        }


        Vector3 pos = transform.position;
        allow_to_shoot = true;
        if (pos.y + ship_radius > Camera.main.orthographicSize)
        {
            allow_to_shoot=false;
        }
        if (pos.y - ship_radius < -Camera.main.orthographicSize)
        {
            allow_to_shoot = false;
        }

        float ScreenRatio = (float)Screen.width / (float)Screen.height;
        float camera_width = ScreenRatio * Camera.main.orthographicSize;

        if (pos.x + ship_radius > camera_width)
        {
            allow_to_shoot = false;
        }
        if (pos.x - ship_radius < -camera_width)
        {
            allow_to_shoot = false;
        }


        coolDownTime -= Time.deltaTime;
        if (allow_to_shoot && coolDownTime <= 0 && player != null)
        {
            Debug.Log("Shoot by sharpshooter");
            coolDownTime = fireDelay;

            Vector3 top_gun = transform.rotation * new Vector3(0.5f, 0, 0);
            Vector3 rotation = transform.rotation.eulerAngles;
            shot_audio.Play();
            Instantiate(bullet_copy, transform.position - top_gun, Quaternion.Euler(rotation));
            shot_audio.Play();
            Instantiate(bullet_copy, transform.position + top_gun, Quaternion.Euler(rotation));
        }
    }
}
