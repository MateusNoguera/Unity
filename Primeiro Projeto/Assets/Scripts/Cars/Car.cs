using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    //em variáveis privadas usar _ antes do nome

    #region Variables
    public int door = 4;

    public float life = 10;
    public float damage = 0.5f;

    public bool canAcelerate = true;

    public GameObject MyObject;
    public Transform MyTransform;
    public Color Color = Color.black;

    #endregion

    public void ChangeColor()
    {
        Color = Color.blue;
        life -= damage;
    }

    public void Acelerate()
    {
        canAcelerate = true;
    }

    #region Methods Unity
    // Start is called before the first frame update
    void Start()
    {
        //transform.position = new Vector3(1, 0, 0);
        GetComponent<BoxCollider>().enabled = false;
        //ChangeColor();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    #endregion
}
