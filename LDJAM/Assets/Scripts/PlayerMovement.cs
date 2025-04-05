using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 3f;
    private Rigidbody2D _rb;
    private SpriteRenderer _sprite;
    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
        _sprite = GetComponentInChildren<SpriteRenderer>();
    }
    private void FixedUpdate()
    {
        _rb.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * _moveSpeed, _rb.velocity.y);
        if (Input.GetAxisRaw("Horizontal") == 1)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
        else if (Input.GetAxisRaw("Horizontal") == -1)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
    }
}
