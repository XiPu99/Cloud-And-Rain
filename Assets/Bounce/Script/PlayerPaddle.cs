using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPaddle : Paddle
{
    private Vector2 _playerPaddleDirection;

    private void Update()
    {
        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            _playerPaddleDirection = Vector2.up;
        }

        else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            _playerPaddleDirection = Vector2.down;
        }

        else
        {
            _playerPaddleDirection = Vector2.zero;
        }
    }

    private void FixedUpdate()
    {
        if(_playerPaddleDirection.sqrMagnitude != 0)
        {
            _rigidBody.AddForce(_playerPaddleDirection * this.speed);
        }
    }
}
