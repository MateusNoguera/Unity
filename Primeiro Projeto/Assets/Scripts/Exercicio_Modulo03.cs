using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercicio_Modulo03 : MonoBehaviour
{
    [Header("Number")]
    public int Num = 0;

    [Header("Text")]
    public string Str = "";

    //[Header("Inputs")]
    private KeyCode Key1 = KeyCode.A;
    private KeyCode Key2 = KeyCode.S;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(Key1))
        {
            Num++;
            //Debug.Log(Num);
        }

        if (Input.GetKeyUp(Key2))
        {
            Str += "A";
            //Debug.Log(Str);
        }

    }
}
