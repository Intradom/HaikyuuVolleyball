using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    [SerializeField]
    private Player_Control script_player_control;
    [SerializeField]
    private float player_speed = 0;

    void FixedUpdate()
    {
        float move_x = Time.fixedDeltaTime * player_speed * Input.GetAxis("Horizontal");

        script_player_control.Move(move_x, false, Input.GetButton("Jump"));
    }
}
