using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingHorizontalPlatform : MonoBehaviour
{

    public float distance = 1.5f;
    public float platformSpeed = 10f;
    private float min;
    private float max;
    private bool movingRight = true;
    //private bool collisionBelow = false;

    // Use this for initialization
    void Start()
    {
        min = transform.position.x - distance;
        max = transform.position.x + distance;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 platform = transform.position;
        if (movingRight)
        {
            platform.x += platformSpeed/1000;
            if (platform.x >= max)
                movingRight = false;
        }
        else
        {
            platform.x -=  platformSpeed/1000;
            if (platform.x <= min)
                movingRight = true;
        }
        transform.position = platform;
    }
}
