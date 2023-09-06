using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownMovement : MonoBehaviour
{
    [SerializeField] private float movementSpeed = 10f;
    private TopDownCharacterController _controller;

    private Vector2 _movementDirection = Vector2.zero;
    private Rigidbody2D _rigidbody;

    [SerializeField] private Animator _animator;

    private void Awake()
    {
        _controller = GetComponent<TopDownCharacterController>();
        _rigidbody = GetComponent<Rigidbody2D>();
        string playerType = GameManager.M.GetPlayerType();
        _animator = gameObject.transform.Find(playerType).gameObject.GetComponent<Animator>();
    }

    private void Start()
    {
        _controller.OnMoveEvent += Move;
    }

    private void FixedUpdate()
    {
        if(_movementDirection ==  Vector2.zero)
        {
            _animator.SetBool("isRun", false);
        }
        else
        {
            _animator.SetBool("isRun", true);
        }
        ApplyMovment(_movementDirection);
    }

    private void Move(Vector2 direction)
    {
        _movementDirection = direction;
    }

    private void ApplyMovment(Vector2 direction)
    {
        direction = direction * movementSpeed;

        _rigidbody.velocity = direction;
    }
}
