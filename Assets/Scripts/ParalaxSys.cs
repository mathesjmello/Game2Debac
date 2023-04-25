using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 // coloque esse script em cada uma das imagens de fundo que forem se mexer quando o personagem andar
//controle a velocidade pelo layer order da imagem no inspector, quanto menor o valor mais lento vai se mover
public class ParalaxSys : MonoBehaviour
{
    public float speed;
    private GameObject _player;
    private SpriteRenderer _sr;
    private Vector3 _startPos;
    private void Awake()
    {
        _startPos = transform.position;
    }

    void Start()
    {
        _player = FindObjectOfType<Move>().gameObject;
        _sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        var distX = _startPos.x - _player.transform.position.x;
        transform.position = new Vector3(_startPos.x+distX/Math.Abs(_sr.sortingOrder)*speed, _startPos.y);
    }
}
