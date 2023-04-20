using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    private Collider2D col;
    // Start is called before the first frame update
    void Start()
    {
        col = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("bati na parede");
        var p = other.transform.gameObject.GetComponent<Move>();
        p.wall = true;
    }
    private void OnCollisionExit2D(Collision2D other) {
        var p = other.transform.gameObject.GetComponent<Move>();
        p.wall = false;
    }
}