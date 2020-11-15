using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Generator : MonoBehaviour
{

    public GameObject needle_green;
    public GameObject needle_orange;
    public GameObject needle_orange_2;
    public GameObject needle_blue;

    int number_of_needles;
    int current_needles_number;
    float enemy_spawn_distance = 10f;
    float nextenemy = 1;
    float enemyRate = 5;
    int first_bound;
    private void Start()
    {
        number_of_needles = Random.Range(30, 50);
        first_bound = 2 * number_of_needles/3;
        current_needles_number=0;
    }
    // Update is called once per frame
    void Update()
    {
        nextenemy -= Time.deltaTime;
        if (nextenemy <= 0 && (current_needles_number<=number_of_needles))
        {
            current_needles_number++;
            nextenemy = enemyRate;
            enemyRate *= 0.95f;
            if (enemyRate < 2)
            {
                enemyRate = 2;
            }
            Vector3 offset = Random.onUnitSphere;

            offset.z = 0;
            offset = offset.normalized * enemy_spawn_distance;
            int temp_needle_choice = Random.Range(1, 5);
            if (temp_needle_choice == 1)
            {
                Instantiate(needle_green, transform.position + offset, Quaternion.identity);
                Debug.Log("green needle comming");
            }
            else if (temp_needle_choice == 2)
            {
                Instantiate(needle_orange, transform.position + offset, Quaternion.identity);
                Debug.Log("orange needle comming");
            }
            else if (temp_needle_choice == 3)
            {
                Instantiate(needle_orange_2, transform.position + offset, Quaternion.identity);
                Debug.Log("orange brother needle comming");
            }
            else
            {
                Instantiate(needle_blue, transform.position + offset, Quaternion.identity);
                Debug.Log("blue needle comming");
            }
        }
        if (current_needles_number < first_bound)
        {
            //here comes the sharpshooters
        }
        if (current_needles_number > number_of_needles)
        {
            // here comes the bommber
        }
    }
}
