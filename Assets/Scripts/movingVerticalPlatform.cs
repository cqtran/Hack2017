using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingVerticalPlatform : MonoBehaviour {
    public float distance = 1.5f;
    public float platformSpeed = 10f;
    private float min;
    private float max;
    private bool movingUp = true;
    Ray2D ray;
    // Use this for initialization
    void Start()
    {
        min = transform.position.y;
        max = transform.position.y + 2 * distance;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 platform = transform.position;
        if (movingUp)
        {
            platform.y += platformSpeed / 1000;
            if (platform.y >= max)
                movingUp = false;
        }
        else
        {
                platform.y -= platformSpeed / 1000;
                if (platform.y <= min)
                    movingUp = true;
        }
        transform.position = platform;
    }
}
