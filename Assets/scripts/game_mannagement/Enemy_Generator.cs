﻿using System.Collections;
using System.Collections.Generic;

// if error of policy change System.Security.Policy to System.Security
using System.Security;
using UnityEngine;

public class Enemy_Generator : MonoBehaviour
{

    public GameObject needle_green;
    public GameObject needle_orange;
    public GameObject needle_orange_2;
    public GameObject needle_blue;
    public GameObject sharpshooter1;
    public GameObject sharpshooter2;
    public GameObject sharpshooter3;
    public GameObject sharpshooter4;
    public GameObject sharpshooter5;
    public GameObject sharpshooter6;

    int number_of_needles;
    int current_needles_number;
    float enemy_spawn_distance = 10f;
    float nextenemy = 1;
    float nextshooter = 1;
    float enemyRate = 5;
    float sharp_shooter_rate = 10;
    int first_bound;
    int temp_needle_choice = 1;
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
        if (nextenemy <= 0 && (current_needles_number<=number_of_needles) && temp_needle_choice<=6)
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
            temp_needle_choice++;
        }
        nextshooter -= Time.deltaTime;
        if (nextshooter <= 0 && current_needles_number > first_bound)
        {
            //here comes the sharpshooters
            current_needles_number++;
            nextshooter = sharp_shooter_rate;
            sharp_shooter_rate *= 0.95f;
            if (sharp_shooter_rate < 2)
            {
                sharp_shooter_rate = 2;
            }
            Vector3 offset = Random.onUnitSphere;

            offset.z = 0;
            offset = offset.normalized * enemy_spawn_distance;
            int temp_needle_choice = Random.Range(1, 7);
            if (temp_needle_choice == 1)
            {
                Instantiate(sharpshooter1, transform.position + offset, Quaternion.identity);
                Debug.Log("sharpshooter1 comming");
            }
            else if (temp_needle_choice == 2)
            {
                Instantiate(sharpshooter2, transform.position + offset, Quaternion.identity);
                Debug.Log("sharpshooter2 comming");
            }
            else if (temp_needle_choice == 3)
            {
                Instantiate(sharpshooter3, transform.position + offset, Quaternion.identity);
                Debug.Log("sharpshooter3 comming");
            }
            else if (temp_needle_choice == 4)
            {
                Instantiate(sharpshooter4, transform.position + offset, Quaternion.identity);
                Debug.Log("sharpshooter4 comming");
            }
            else if (temp_needle_choice == 5)
            {
                Instantiate(sharpshooter5, transform.position + offset, Quaternion.identity);
                Debug.Log("sharpshooter5 comming");
            }
            else
            {
                Instantiate(sharpshooter6, transform.position + offset, Quaternion.identity);
                Debug.Log("sharpshooter6 comming");
            }
        }
        if (current_needles_number > number_of_needles)
        {
            // here comes the bommber
        }
    }
}
