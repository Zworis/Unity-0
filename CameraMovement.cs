using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    // Start is called before the first frame update

    Vector3 camera_position;
    GameObject player;
    void Start()
    {
        player = GameObject.Find("Sphere");
        camera_position = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + camera_position;
    }
}
