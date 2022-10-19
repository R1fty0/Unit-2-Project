using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    public float move_speed = 20f;
    public Rigidbody player;

    void FixedUpdate()
    {
        horizontal_movement();
        vertical_movement();
    }

    void horizontal_movement()
    {
        //Moves Player to the Right.
        if(Input.GetKey("a"))
        {
            player.AddForce(-move_speed/2, 0, 0 , ForceMode.VelocityChange);
        }
        
        //Moves Player to the Left.
        if (Input.GetKey("d"))
        {
            player.AddForce(move_speed/2, 0, 0, ForceMode.VelocityChange);
        }
    }

    void vertical_movement()
    {
        //Moves Player Forward.
        if (Input.GetKey("w"))
        {
            player.AddForce(0,0,move_speed/2,  ForceMode.VelocityChange);
        }

        //Moves Player Backwards
        if (Input.GetKey("s"))
        {
            player.AddForce(0,0,-move_speed/2, ForceMode.VelocityChange);
        }
    }
}

