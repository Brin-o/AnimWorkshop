using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LRCharacter : MonoBehaviour
{
    float speed = 50;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        speed = Input.GetAxisRaw("Horizontal")*speed;
        Vector2 newPos = new Vector2(transform.position.x + speed, transform.position.y);
        transform.position = newPos;
    }
}
