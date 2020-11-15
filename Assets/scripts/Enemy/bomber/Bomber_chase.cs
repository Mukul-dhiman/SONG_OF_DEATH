using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomber_chase : MonoBehaviour
{
    Transform player;
    public float maxSpeed = 50f; 
    public float speed = 1;
    public float circumference = 5;
    public float count = 0;
    GameObject go;
    bool inside = true;

    // Update is called once per frame
    void Update()
    {
        if (player == null)
        {
            go = GameObject.FindWithTag("Player");
            if (go != null)
            {
                player = go.transform;
            }
        }

        if (player == null)
        {
            return;
        }
        if (inside)
        {
            if (Vector3.Distance(transform.position, player.position) > 4)
            {
                Vector3 pos = transform.position;
                Vector3 velocity = new Vector3(0, maxSpeed * Time.deltaTime, 0);
                pos += transform.rotation * velocity;
                transform.position = pos;
            }
            else
            {
                inside = false;
            }
        }
        else
        {
            if (Vector3.Distance(transform.position, player.position) < 5)
            {
                Vector3 pos = transform.position;
                Vector3 velocity = new Vector3(-1*maxSpeed * Time.deltaTime,0, 0);
                pos += transform.rotation * velocity;
                transform.position = pos;
            }
            else
            {
                inside = true;
            }
        }
    }
}
