using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_spawn : MonoBehaviour
{
    public GameObject player_prefab;
    float respawntime=1;
    GameObject Player_Instance;
    public int number_of_lives = 4;
    bool continuegame = true;

    // Start is called before the first frame update
    void Start()
    {
        spawn_player();
    }

    void spawn_player()
    {
        number_of_lives--;
        respawntime = 1;
        Player_Instance = (GameObject)Instantiate(player_prefab, transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    { 

        if (number_of_lives < 0){
            continuegame = false;
            Debug.Log("game end");
        }
        if(Player_Instance == null  && continuegame)
        {
            respawntime -= Time.deltaTime;
            if (respawntime <= 0)
            {
                spawn_player();
            }
        }   
      
    }

    private void OnGUI()
    {
        if (number_of_lives >= 0)
        {
            GUI.Label(new Rect(0, 0, 100, 50), "Lives: " + number_of_lives);
        }
        else
        {
            GUI.Label(new Rect(Screen.width/2-50, Screen.height/2-50, 100, 50), "GAME OVE!!!");
        }
    }
}
