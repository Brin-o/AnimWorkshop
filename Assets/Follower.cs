using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follower : MonoBehaviour
{
    public Transform target;
    public float followSpeed = 10;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        var currentX = transform.position.x;
        var targetX = target.position.x;

        var desiredX = Mathf.Lerp(currentX, targetX, Time.deltaTime * 10);

        transform.position = new Vector2(desiredX, transform.position.y);


    }
}
