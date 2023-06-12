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
    public GameObject fade;
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
        Click();
    }

    void Click (){

        if (door != null)
        {
            fade.SetActive(true);
            door.Interaction();
            
        }
    }
    
}
