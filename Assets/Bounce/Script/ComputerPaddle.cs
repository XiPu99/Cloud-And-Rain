using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComputerPaddle : Paddle
{
    public Rigidbody2D _ball;

    public float _damping = 1.0f;

    private void FixedUpdate()
    {
        if(this._ball.velocity.x > 0.0f)
        {
            if((this._ball.position.y * _damping) > this.transform.position.y)
            {
                _rigidBody.AddForce(Vector2.up * this.speed);
            }
            else if((this._ball.position.y * _damping) < this.transform.position.y)
            {
                _rigidBody.AddForce(Vector2.down * this.speed);
            }
        }
        else
        {
            if (this.transform.position.y > 0.0f)
            {
                _rigidBody.AddForce(Vector2.down * this.speed);
            }
            else if (this.transform.position.y < 0.0f)
            {
                _rigidBody.AddForce(Vector2.up * this.speed);
            }
        }
    }

}
