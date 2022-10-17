using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Camera : MonoBehaviour
{
    public Vector3 cameraPosition;
    public Transform player;

    void Update()
    {
        transform.position = player.position + cameraPosition;
        transform.LookAt(player);
    }
}