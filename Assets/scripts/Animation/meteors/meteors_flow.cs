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
    float next_meteor = 0;
    float meteor_rate = 0.5f;
    // Update is called once per frame
    void Update()
    {

        next_meteor -= Time.deltaTime;
        if (next_meteor <= 0)
        {
            next_meteor = meteor_rate;
            Vector3 offset = Random.onUnitSphere;

            offset.z = 0;
            offset = offset.normalized * meteor_spawn_distance;

            Vector3 dir = Random.onUnitSphere*4;
            dir.z = 0;
            dir -= offset;
            int p = Random.Range(1, 101);
            if (p < 15)
            {
                float zangle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg-90;
                Quaternion desiardrotation = Quaternion.Euler(0, 0, zangle);
                Instantiate(m1, transform.position + offset, Quaternion.Euler(0, 0, zangle));
            }
            else if (p < 30)
            {
                float zangle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg - 90;
                Quaternion desiardrotation = Quaternion.Euler(0, 0, zangle);
                Instantiate(m2, transform.position + offset, Quaternion.Euler(0, 0, zangle));
            }
            else if (p < 40)
            {
                float zangle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg - 90;
                Quaternion desiardrotation = Quaternion.Euler(0, 0, zangle);
                Instantiate(m3, transform.position + offset, Quaternion.Euler(0, 0, zangle));
            }
            else if (p < 50)
            {
                float zangle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg - 90;
                Quaternion desiardrotation = Quaternion.Euler(0, 0, zangle);
                Instantiate(m4, transform.position + offset, Quaternion.Euler(0, 0, zangle));
            }
            else if (p < 60)
            {
                float zangle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg - 90;
                Quaternion desiardrotation = Quaternion.Euler(0, 0, zangle);
                Instantiate(m5, transform.position + offset, Quaternion.Euler(0, 0, zangle));
            }
            else if (p < 67)
            {
                float zangle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg - 90;
                Quaternion desiardrotation = Quaternion.Euler(0, 0, zangle);
                Instantiate(m6, transform.position + offset, Quaternion.Euler(0, 0, zangle));
            }
            else if (p < 74)
            {
                float zangle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg - 90;
                Quaternion desiardrotation = Quaternion.Euler(0, 0, zangle);
                Instantiate(m7, transform.position + offset, Quaternion.Euler(0, 0, zangle));
            }
            else if (p < 80)
            {
                float zangle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg - 90;
                Quaternion desiardrotation = Quaternion.Euler(0, 0, zangle);
                Instantiate(m8, transform.position + offset, Quaternion.Euler(0, 0, zangle));
            }
            else if (p < 85)
            {
                float zangle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg - 90;
                Quaternion desiardrotation = Quaternion.Euler(0, 0, zangle);
                Instantiate(m9, transform.position + offset, Quaternion.Euler(0, 0, zangle));
            }
            else if (p < 88)
            {
                float zangle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg - 90;
                Quaternion desiardrotation = Quaternion.Euler(0, 0, zangle);
                Instantiate(m10, transform.position + offset, Quaternion.Euler(0, 0, zangle));
            }
            else if (p < 91)
            {
                float zangle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg - 90;
                Quaternion desiardrotation = Quaternion.Euler(0, 0, zangle);
                Instantiate(m11, transform.position + offset, Quaternion.Euler(0, 0, zangle));
            }
            else if (p < 94)
            {
                float zangle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg - 90;
                Quaternion desiardrotation = Quaternion.Euler(0, 0, zangle);
                Instantiate(m12, transform.position + offset, Quaternion.Euler(0, 0, zangle));
            }
            else if (p < 96)
            {
                float zangle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg - 90;
                Quaternion desiardrotation = Quaternion.Euler(0, 0, zangle);
                Instantiate(m13, transform.position + offset, Quaternion.Euler(0, 0, zangle));
            }
            else if (p < 98)
            {
                float zangle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg - 90;
                Quaternion desiardrotation = Quaternion.Euler(0, 0, zangle);
                Instantiate(m14, transform.position + offset, Quaternion.Euler(0, 0, zangle));
            }
            else
            {
                float zangle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg - 90;
                Quaternion desiardrotation = Quaternion.Euler(0, 0, zangle);
                Instantiate(m15, transform.position + offset, Quaternion.Euler(0, 0, zangle));   
            }
        }
        
    }
}
