using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meteors_flow : MonoBehaviour
{
    float meteor_spawn_distance=10;
    public GameObject m1;
    public GameObject m2;
    public GameObject m3;
    public GameObject m4;
    public GameObject m5;
    public GameObject m6;
    public GameObject m7;
    public GameObject m8;
    public GameObject m9;
    public GameObject m10;
    public GameObject m11;
    public GameObject m12;
    public GameObject m13;
    public GameObject m14;
    public GameObject m15;
    // Update is called once per frame
    void Update()
    {
        Vector3 offset = Random.onUnitSphere;

        offset.z = 0;
        offset = offset.normalized * meteor_spawn_distance;

        Vector3 dir = Random.onUnitSphere;
        dir.z = 0;
        dir -= offset;
        int p = Random.Range(1, 101);
        if (p < 15)
        {
            Instantiate(m1, transform.position + offset, Quaternion.Euler(dir));
        }
        else if (p < 30)
        {
            Instantiate(m2, transform.position + offset, Quaternion.Euler(dir));
        }
        else if (p < 40)
        {
            Instantiate(m3, transform.position + offset, Quaternion.Euler(dir));
        }
        else if (p < 50)
        {
            Instantiate(m4, transform.position + offset, Quaternion.Euler(dir));
        }
        else if (p < 60)
        {
            Instantiate(m5, transform.position + offset, Quaternion.Euler(dir));
        }
        else if (p < 67)
        {
            Instantiate(m6, transform.position + offset, Quaternion.Euler(dir));
        }
        else if (p < 74)
        {
            Instantiate(m7, transform.position + offset, Quaternion.Euler(dir));
        }
        else if (p < 80)
        {
            Instantiate(m8, transform.position + offset, Quaternion.Euler(dir));
        }
        else if (p < 85)
        {
            Instantiate(m9, transform.position + offset, Quaternion.Euler(dir));
        }
        else if (p < 88)
        {
            Instantiate(m10, transform.position + offset, Quaternion.Euler(dir));
        }
        else if (p < 91)
        {
            Instantiate(m11, transform.position + offset, Quaternion.Euler(dir));
        }
        else if (p < 94)
        {
            Instantiate(m12, transform.position + offset, Quaternion.Euler(dir));
        }
        else if (p < 96)
        {
            Instantiate(m13, transform.position + offset, Quaternion.Euler(dir));
        }
        else if (p < 98)
        {
            Instantiate(m14, transform.position + offset, Quaternion.Euler(dir));
        }
        else
        {
            Instantiate(m15, transform.position + offset, Quaternion.Euler(dir));
        }
    }
}
