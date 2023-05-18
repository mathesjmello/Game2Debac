using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraWall : MonoBehaviour
{
private Move player;
private Camera camera;

public bool varanda;

public Transform varandaObj;
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
        if (varanda)
        {
            camera.transform.SetParent(varandaObj);
            camera.transform.localPosition = new Vector3(0, 5.28f, -1);
            player.transform.localScale = new Vector3(0.23f, 0.23f, 0.23f);
            return;
        }
        camera.transform.SetParent(null);
    }

    private void OnTriggerExit2D(Collider2D other) {
        camera.transform.SetParent(player.transform);
        if (varanda)
        {
            camera.transform.localPosition = new Vector3(0, 5.5f, -10);
            player.transform.localScale = new Vector3(0.62f, 0.62f, 0.62f);
        }
    }
}
