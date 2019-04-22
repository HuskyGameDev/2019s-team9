using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserY : MonoBehaviour {

    public float moveSpeed = 10;
    public float maxY = 100.0f;
    public float minY;
    
    public float sleepTime = 0.0f;
    private float time;

    private bool dir = true;
    private Vector3 objectPosition;
    private float curY;

    private void Start()
    {
        objectPosition = transform.position;
        minY = objectPosition.y;
        curY = minY;
        time = Time.time;
        
    }
    // Update is called once per frame
    void Update () {

        if (Time.time >= time + sleepTime)
        {
            if (dir)
            {
                transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);
                curY = transform.position.y;

                if (curY >= maxY)
                    dir = false;
            }
            if (!dir)
            {
                transform.Translate(Vector3.down * moveSpeed * Time.deltaTime);
                curY = transform.position.y;

                if (curY <= minY)
                    dir = true;
            }
        }
    }
}
