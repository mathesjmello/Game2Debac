using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other) {
        var p = other.transform.gameObject.GetComponent<Move>();
        p.AnimControl(false);
    }
    private void OnCollisionExit2D(Collision2D other) {
        var p = other.transform.gameObject.GetComponent<Move>();
        p.AnimControl(true);
    }
}