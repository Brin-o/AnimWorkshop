using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Squash : MonoBehaviour
{
    Rigidbody2D _rb;
    public float acceleration = 10;
    public float rotaitonSpeed = 10;
    public float maxSpeed = 100;
    [Range(0, 1)] public float remapedSpeed;

    public bool applySquash = false;


    public float speed;
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        if (applySquash)
        {
            SquashandStretch();
        }
    }

    void SquashandStretch()
    {
        remapedSpeed = speed / maxSpeed;
        Vector2 newScale;
        newScale.x = 1 - remapedSpeed / 3;
        newScale.y = 1 / newScale.x;
        transform.localScale = newScale;

    }

    void Movement()
    {
        if (Input.GetKey(KeyCode.UpArrow))
            _rb.velocity += (Vector2)transform.up * acceleration * Time.deltaTime;
        else
            _rb.velocity = Vector3.Lerp(_rb.velocity, Vector3.zero, Time.deltaTime * 8);

        _rb.velocity = Vector2.ClampMagnitude(_rb.velocity, maxSpeed);
        if (Input.GetKey(KeyCode.LeftArrow))
            transform.Rotate(0, 0, rotaitonSpeed * Time.deltaTime);
        else if (Input.GetKey(KeyCode.RightArrow))
            transform.Rotate(0, 0, -rotaitonSpeed * Time.deltaTime);
        speed = _rb.velocity.magnitude;
    }
}
