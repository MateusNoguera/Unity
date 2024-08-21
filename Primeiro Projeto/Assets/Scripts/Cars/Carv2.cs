using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carv2 : MonoBehaviour
{
    [Header("Variáveis")]
    public Color Color = Color.black;

    [Header("Inputs")]
    public KeyCode keyCode = KeyCode.Alpha3;
    private void ChangeColor(Color NewColor)
    {
        Color = NewColor;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(keyCode))
        {
            ChangeColor(Color.yellow);
        }
        else if (Input.GetKeyUp(keyCode))
        {
            ChangeColor(Color.red);
        }
        else if (Input.GetKey(keyCode))
        {
            ChangeColor(Color.blue);
        }

        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Mouse down");
        }

        if (Input.GetButtonDown("Jump"))
        {

        }
    }
}
