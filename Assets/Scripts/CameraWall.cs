using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraWall : MonoBehaviour
{
private Move player;
private Camera camera;
    // Start is called before the first frame update
    void Start()
    {
        camera = FindObjectOfType<Camera>();
        player = FindObjectOfType<Move>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other) {
        camera.transform.SetParent(null);
    }

    private void OnTriggerExit2D(Collider2D other) {
        camera.transform.SetParent(player.transform);
    }
}
