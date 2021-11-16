using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class LRCharacter : MonoBehaviour
{
    public float speed = 50;
    SpriteRenderer sprite;
    void Start()
    {
        sprite = GetComponentInChildren<SpriteRenderer>();
    }

    float t;
    void Update()
    {
        t += Time.deltaTime;
        var x = Input.GetAxisRaw("Horizontal") * speed;
        if (x != 0)
        {
            // if (DOTween.IsTweening("wiggle") == false)
            //     sprite.transform.DORotate(new Vector3(0, 0, -20), 0.1f, RotateMode.Fast).SetId("wiggle").SetLoops(0, LoopType.Yoyo);
            var z = Mathf.Sin(t * 20) * 30;
            sprite.transform.rotation = Quaternion.Euler(0, 0, z);
        }
        Vector2 newPos = new Vector2(transform.position.x + x, transform.position.y);
        transform.position = newPos;
    }
}
