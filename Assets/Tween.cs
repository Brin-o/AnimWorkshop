using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class Tween : MonoBehaviour
{
    public AnimationCurve curve1;

    public AnimationCurve curve2;
    public AnimationCurve curve3;




    Vector3 startPos;

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //if(DOTween.IsTweening("xscale"))
            transform.DOMoveX(9, 1).SetEase(curve1).OnComplete(() => { print("Hi"); });
            //transform.DOScaleX(3, 0.3f).SetEase(curve1).SetId("xscale");
            //transform.DOScaleY(3, 0.3f).SetEase(curve2);

        }


        if (Input.GetKeyDown(KeyCode.R)) transform.position = startPos;
    }
}
