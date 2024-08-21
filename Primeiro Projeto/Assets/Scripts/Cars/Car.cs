using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    //em variáveis privadas usar _ antes do nome
    [Header("Variáveis")]
    #region Variables
    public int door = 4;

    public float life = 10;
    public float damage = 0.5f;

    public bool canAcelerate = true;

    [Header("Referências")]
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

    private void Awake()
    {
        //Debug.Log("Awake");
    }

    #region Methods Unity
    // Start is called before the first frame update
    void Start()
    {
        //transform.position = new Vector3(1, 0, 0);
        GetComponent<BoxCollider>().enabled = false;
        //ChangeColor();
        //Debug.Log("Start");
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Update");
    }

    // LateUpdate is called after the update method
    private void LateUpdate()
    {
        //Debug.Log("LateUpdate");
    }

    
    private void FixedUpdate()
    {
        //Debug.Log("FixedUpdate");
    }

    private void OnEnable()
    {
        //Debug.Log("OnEnable");
    }

    private void OnDisable()
    {
        //Debug.Log("OnDisable");
    }

    private void OnDestroy()
    {
        //Debug.Log("OnDestroy");
    }
    #endregion
}
