using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Generator : MonoBehaviour
{

    public GameObject needles;

    float enemy_spawn_distance = 10f;
    float nextenemy = 1;
    float enemyRate = 5;


    // Update is called once per frame
    void Update()
    {
        nextenemy -= Time.deltaTime;
        if (nextenemy <= 0)
        {
            nextenemy = enemyRate;
            enemyRate *= 0.95f;
            if (enemyRate < 2)
            {
                enemyRate = 2;
            }
            Vector3 offset = Random.onUnitSphere;

            offset.z = 0;
            offset = offset.normalized * enemy_spawn_distance;
            Instantiate(needles, transform.position + offset, Quaternion.identity);
        }
    }
}
