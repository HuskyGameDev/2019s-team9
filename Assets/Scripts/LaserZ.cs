using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserZ : MonoBehaviour {

    public float moveSpeed = 10;
    public float maxZ = 100.0f;
    public float minZ;
    
    public float sleepTime = 0.0f;
    private float time;

    public bool dir = true;
    private Vector3 objectPosition;
    private float curZ;

    private void Start()
    {
        objectPosition = transform.position;
        if (dir)
        {
            minZ = objectPosition.z;
        }
        
        curZ = minZ;
        time = Time.time;
        
    }
    // Update is called once per frame
    void Update () {

        if (Time.time >= time + sleepTime)
        {
            if (dir)
            {
                transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
                curZ = transform.position.z;

                if (curZ >= maxZ)
                    dir = false;
            }
            if (!dir)
            {
                transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);
                curZ = transform.position.z;

                if (curZ <= minZ)
                    dir = true;
            }
        }
    }
}
