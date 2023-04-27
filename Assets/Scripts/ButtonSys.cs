using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;
using UnityEngine.UI;

public class ButtonSys : MonoBehaviour
{
    Button btn;
    public Door door;
    void Start()
    {
        btn = gameObject.GetComponent<Button>();
        btn.onClick.AddListener(Click);
    }

    void Click (){

        if (door != null)
        {
            door.Interaction();
        }
    }
}
