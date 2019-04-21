using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserX : MonoBehaviour {

    public float moveSpeed = 10;
    public float maxX = 100.0f;
    public float minX;
    
    public float sleepTime = 0.0f;
    private float time;

    public bool dir = true;
    private Vector3 objectPosition;
    private float curX;

    private void Start()
    {
        objectPosition = transform.position;
        if(dir)
        {
            minX = objectPosition.x;
        }
        
        curX = minX;
        time = Time.time;
        
    }
    // Update is called once per frame
    void Update () {

        if (Time.time >= time + sleepTime)
        {
            if (dir)
            {
                transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
                curX = transform.position.x;

                if (curX >= maxX)
                    dir = false;
            }
            if (!dir)
            {
                transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
                curX = transform.position.x;

                if (curX <= minX)
                    dir = true;
            }
        }
    }
}
