using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDistruction : MonoBehaviour
{
    public float distruction_timer = 5f;
    void Update()
    {
        distruction_timer -= Time.deltaTime;
        if(distruction_timer <= 0)
        {
            Destroy(gameObject);
        }
    }
}
