using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float horizontalMove;
    public float verticalMove;
    public CharacterController Player;

    public float speed;

    void Start()
    {
        Player = GetComponent<CharacterController>();
    }

    void Update()
    {
        horizontalMove = Input.GetAxis("Horizontal");
        verticalMove = Input.GetAxis("Vertical");
    }
    private void FixedUpdate()
    {
                Player.Move(new Vector3 (horizontalMove,0, verticalMove) * speed * Time.deltaTime);
    }
}
