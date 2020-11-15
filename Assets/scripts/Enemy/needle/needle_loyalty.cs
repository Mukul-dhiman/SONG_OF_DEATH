using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class needle_loyalty : MonoBehaviour
{
    Transform player;
    public float rotspeed= 10f;
    void Update()
    {
        if(player == null)
        {

            GameObject go = GameObject.FindWithTag("Player");
            if (go != null)
            {
                player = go.transform;
            }
        }

         if(player == null)
        {

            return;
        }

        Vector3 dir = player.position - transform.position;
        dir.Normalize();
        float zangle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg - 270;
        Quaternion desiardrotation = Quaternion.Euler(0, 0, zangle);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, desiardrotation, rotspeed * Time.deltaTime);
    }
}
