using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    [SerializeField]
    private float player_speed = 0;

    private Rigidbody2D ref_rbody;

    void Awake()
    {
        ref_rbody = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        float vel_x = Time.fixedDeltaTime * player_speed * Input.GetAxis("Horizontal");

        ref_rbody.AddForce(new Vector2(vel_x, 0));
    }
}
