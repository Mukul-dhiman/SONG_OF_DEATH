using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class background_motion : MonoBehaviour
{
    // Start is called before the first frame update
    public float maxSpeed = 4.5f;
    public float rotationMaxSpeed = 180f;
    float ship_radius = 0.5f;
    void Start()
    {
        /*Vector3 pos = transform.position;
        pos.x = 0f;
        pos.y = 0f;
        transform.position = pos;
        */
    }

    // Update is called once per frame
    void Update()
    {
        // Rotation
        Quaternion rotation = transform.rotation;
        float z = rotation.eulerAngles.z;
        z -= Input.GetAxis("Horizontal") * rotationMaxSpeed * Time.deltaTime;
        rotation = Quaternion.Euler(0, 0, z);
        transform.rotation = rotation;

        // Moving charles the ship
        Vector3 pos = transform.position;
        Vector3 velocity = new Vector3(0, maxSpeed * Input.GetAxis("Vertical") * Time.deltaTime, 0);
        pos += rotation * velocity;

        //Bounding the ship
        if (pos.y + ship_radius > Camera.main.orthographicSize)
        {
            pos.y = Camera.main.orthographicSize - ship_radius;
        }
        if (pos.y - ship_radius < -Camera.main.orthographicSize)
        {
            pos.y = -Camera.main.orthographicSize + ship_radius;
        }

        float ScreenRatio = (float)Screen.width / (float)Screen.height;
        float camera_width = ScreenRatio * Camera.main.orthographicSize;

        if (pos.x + ship_radius > camera_width)
        {
            pos.x = camera_width - ship_radius;
        }
        if (pos.x - ship_radius < -camera_width)
        {
            pos.x = -camera_width + ship_radius;
        }

        transform.position = pos;


    }
}