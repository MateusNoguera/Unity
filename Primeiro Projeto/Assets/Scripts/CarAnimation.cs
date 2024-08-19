using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CarAnimation : MonoBehaviour
{

    public float duration = 2;
    public Ease ease = Ease.Linear;

    // Start is called before the first frame update
    void Start()
    {
        //se mover até 12 na posição X | na duração 'duration' | usar o ease EASE.
        transform.DOMoveX(12, duration).SetEase(ease);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
