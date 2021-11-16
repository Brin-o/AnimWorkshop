using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class Tween : MonoBehaviour
{
    public AnimationCurve curve;


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
            transform.DOMoveX(9, 1).SetEase(curve);
        }


        if (Input.GetKeyDown(KeyCode.R)) transform.position = startPos;
    }
}
