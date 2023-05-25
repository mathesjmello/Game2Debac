using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Move : MonoBehaviour
{
    private Vector3 _newPos; // salva a posiçao do click quando acontece
    public Rigidbody2D rgb; // fisicas do corpo do personagem
    public float speed = 5; // velocidade de movimentaçao
    private static Vector2 _dir;   // direçao em que o personagem esta andando
    public SpriteRenderer sprite;
    private Animator _anim;
    private PlayerInputActions _inputActions;
    

    private void Awake()
    {
        
        _anim = GetComponent<Animator>();
        _inputActions = new PlayerInputActions();
        _inputActions.Player1.Enable();
        _inputActions.Player1.WalkMouse.performed += WalkClick;
        _inputActions.Player1.WalkMouse.canceled += StopWalk;
        _inputActions.Player1.Walk.performed += Walk;
        _inputActions.Player1.Walk.canceled += StopWalk;
        _dir = Vector2.zero;
    }


    private void StopWalk(InputAction.CallbackContext obj)
    {
        _dir = Vector2.zero;
        AnimControl(false);
    }

    private void Walk(InputAction.CallbackContext obj)
    {
        Vector2 inputVec = _inputActions.Player1.Walk.ReadValue<Vector2>();
        _dir = inputVec;
       // audio.Play(0);
        AnimControl(true);
    }

    private void WalkClick(InputAction.CallbackContext obj)
    {
        AnimControl(true);
        
        _newPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (transform.position.x < _newPos.x)
        { _dir = Vector2.right; }
        if (transform.position.x > _newPos.x)
        { _dir = Vector2.left;  }
    }

    // Update is called once per frame
    void Update()
    {
        rgb.velocity = _dir * speed;
        if (_dir == Vector2.right) { sprite.flipX = false; } 
        if (_dir == Vector2.left) { sprite.flipX = true; }
        
    }

    public void AnimControl(bool w){
        _anim.SetBool("walk", w);
    }
    
}
