using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_shooting : MonoBehaviour
{
    private AudioSource shot_audio;
    public GameObject bullet_copy;
    public float fireDelay = 3f;
    float coolDownTime = 0;

    Transform player;

    private void Start()
    {
        shot_audio = GetComponent<AudioSource>();
    }

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

        coolDownTime -= Time.deltaTime;
        if ( coolDownTime <= 0 && player!=null && Vector3.Distance(transform.position,player.position)<3)
        {
            Debug.Log("Shoot by enemy");
            coolDownTime = fireDelay;

            Vector3 top_gun = transform.rotation * new Vector3(0, 0.5f, 0);
            Vector3 rotation = transform.rotation.eulerAngles;
            rotation.z += 180;
            shot_audio.Play();
            Instantiate(bullet_copy, transform.position - top_gun, Quaternion.Euler(rotation));
        }
    }
}
