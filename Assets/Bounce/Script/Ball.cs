using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody2D _rigidBody;

    public float speed = 200.0f;

    private void Awake()
    {
        _rigidBody = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        ResetPosition();
        AddStartingForce();
    }

    public void ResetPosition()
    {
        _rigidBody.position = Vector3.zero;
        _rigidBody.velocity = Vector3.zero;
    }

    public void AddStartingForce()
    {
        float _x = Random.value < 0.5f ? -1.0f : 1.0f;
        float _y = Random.value < 0.5f ? Random.Range(-1.0f, -0.5f) : Random.Range(0.5f, 1.0f);

        Vector2 direction = new Vector2(_x, _y);
        _rigidBody.AddForce(direction * this.speed);
    }

    public void AddForceToBall(Vector2 inputForce)
    {
        _rigidBody.AddForce(inputForce);
    }


}
