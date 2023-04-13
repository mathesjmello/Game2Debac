using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonSys : MonoBehaviour
{
    Button btn;
    public GameObject painel;
    // Start is called before the first frame update
    void Start()
    {
        btn = gameObject.GetComponent<Button>();
        btn.onClick.AddListener(ClickDoBotão);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ClickDoBotão (){

        painel.SetActive(true);
        gameObject.SetActive(false);
    }
}
