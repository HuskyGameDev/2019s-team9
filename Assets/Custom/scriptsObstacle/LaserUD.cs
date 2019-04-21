using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserUD : MonoBehaviour {

    public float moveSpeed = 10;
    public float heightMax = 100.0f;
    public float heightMin;
    
    public float sleepTime = 0.0f;
    private float time;

    private bool dir = true;
    private Vector3 objectPosition;
    private float height;

    private void Start()
    {
        objectPosition = transform.position;
        heightMin = objectPosition.y;
        height = heightMin;
        time = Time.time;
        
    }
    // Update is called once per frame
    void Update () {

        if (Time.time >= time + sleepTime)
        {
            if (dir)
            {
                transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);
                height = transform.position.y;

                if (height >= heightMax)
                    dir = false;
            }
            if (!dir)
            {
                transform.Translate(Vector3.down * moveSpeed * Time.deltaTime);
                height = transform.position.y;

                if (height <= heightMin)
                    dir = true;
            }
        }
    }
}
