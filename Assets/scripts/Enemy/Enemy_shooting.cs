using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_shooting : MonoBehaviour
{
    public GameObject bullet_copy;
    public float fireDelay = 0.75f;
    float coolDownTime = 0;

    void Update()
    {
        coolDownTime -= Time.deltaTime;
        if ( coolDownTime <= 0)
        {
            Debug.Log("Shoot");
            coolDownTime = fireDelay;

            Vector3 top_gun = transform.rotation * new Vector3(0, 0.5f, 0);
            Vector3 rotation = transform.rotation.eulerAngles;
            rotation.z += 180;
            Instantiate(bullet_copy, transform.position + top_gun, Quaternion.Euler(rotation));
        }
    }
}
