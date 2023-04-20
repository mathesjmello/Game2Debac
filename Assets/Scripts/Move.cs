using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    private Vector3 newPos; // salva a posiçao do click quando acontece
    public bool inComing; // salva o status do personagem se movendo
    public Rigidbody2D rgb; // fisicas do corpo do personagem
    public float Speed = 5; // velocidade de movimentaçao
    public static int Dir;   // direçao em que o personagem esta andando
    public SpriteRenderer sprite;
    public Animator Anim;
    public bool wall;
    // Start is called before the first frame update
    void Start()
    {
        Dir = 0;
    }

    // Update is called once per frame
    void Update()
    {
        rgb.velocity = new Vector2(Speed * Dir, rgb.velocity.y);
        
        if (Dir > 0) { sprite.flipX = false; }
        if (Dir < 0) { sprite.flipX = true; }

        if (Input.GetMouseButton(0))
        {
            // coloque codigo para mudar a nimação para sentando
            WallControl(true);
            newPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            inComing = true;
            
        }
        if (Input.GetMouseButtonUp(0))
        {
            WallControl(false);
            inComing = false;
            Dir = 0;
        }
        if (inComing)
        {
            if (transform.position.x < newPos.x)
            { Dir = 1; }

            if (transform.position.x > newPos.x)
            { Dir =-1;  }

            if (transform.position.x > newPos.x - .8f && transform.position.x < newPos.x + .8f)
            {
                WallControl(false);
            }
        }
    }

    void WallControl(bool w){
        if(wall){
        Anim.SetBool("walk", false);
        Dir = 0;
        return;
        }
        Anim.SetBool("walk", w);
    }
    
}
