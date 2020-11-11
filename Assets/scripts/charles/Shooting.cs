using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{

    public GameObject bullet_copy;
    public float fireDelay = 0.25f;
    float coolDownTime = 0;

    void Update()
    {
        coolDownTime -= Time.deltaTime;
        if(Input.GetButton("Jump") && coolDownTime <= 0)
        {
            Debug.Log("Shoot");
            coolDownTime = fireDelay;

            Vector3 top_gun = transform.rotation * new Vector3(0, 0.5f, 0);
            Instantiate(bullet_copy, transform.position + top_gun, transform.rotation);
        }
    }
}
