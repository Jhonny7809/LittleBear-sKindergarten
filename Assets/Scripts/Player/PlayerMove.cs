using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float horizontalMove;
    public float verticalMove;
    public CharacterController player;

    public float speed;

    private void Start()
    {
         player = GetComponent<CharacterController>();
    }

    private void Update()
    {
        horizontalMove = Input.GetAxis("Horizontal");
        verticalMove = Input.GetAxis("Vertical");
    }
    private void FixedUpdate()
    {
            player.Move(new Vector3 (horizontalMove,0, verticalMove) * speed * Time.deltaTime);
    }
}
