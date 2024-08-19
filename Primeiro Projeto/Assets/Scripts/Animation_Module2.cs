using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Animation_Module2 : MonoBehaviour
{

    public float duration1 = 1;
    public float duration2 = 2;
    public Ease ease1 = Ease.Linear;
    public Ease ease2 = Ease.InBounce;

    // Start is called before the first frame update
    void Start()
    {
        transform.DOMoveZ(0, duration1).SetEase(ease1);
        transform.DOMoveX(15, duration2);
        //transform.DOMoveX(5, duration1);
        //transform.DOMoveZ(-6, duration2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
