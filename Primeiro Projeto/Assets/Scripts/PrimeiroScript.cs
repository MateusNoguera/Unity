using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrimeiroScript : MonoBehaviour
{

    public float position;

    // Start is called before the first frame update
    void Start()
    {
        position = PlayerPrefs.GetFloat("POSICAO", 1);

        //position = position + 1;
        position++;

        PlayerPrefs.SetFloat("POSICAO", position);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
