using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sharpshooter_aI_follow : MonoBehaviour
{
    Transform player;
    public float maxSpeed = 50f;

    // Update is called once per frame
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

        if (player == null)
        {

            return;
        }
        if(Vector3.Distance(transform.position, player.position) > 4)
        {
            Vector3 pos = transform.position;
            Vector3 velocity = new Vector3(0, maxSpeed * Time.deltaTime, 0);
            pos += transform.rotation * velocity;
            transform.position = pos;
        }
    }
}
