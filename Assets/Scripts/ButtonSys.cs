using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class ButtonSys : MonoBehaviour
{
    Button btn;
    public Door door;
    private PlayerInputActions _inputActions;

private void Awake() {
    _inputActions = new PlayerInputActions();
    _inputActions.Player1.Enable();
    _inputActions.Player1.E.performed += EClick;
}

    void Start()
    {
        btn = gameObject.GetComponent<Button>();
        btn.onClick.AddListener(Click);
        
    }

    private void EClick(InputAction.CallbackContext obj){
        Debug.Log("entrou no input");
        Click();
    }

    void Click (){

Debug.Log("clicou na porta");
        if (door != null)
        {
            door.Interaction();
        }
    }
}
