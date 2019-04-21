using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DWalls : MonoBehaviour {

    public GameObject[] walls = new GameObject[6];
    private GameObject tracker;
    private bool destroyed = false;
    private int i;

	// Use this for initialization
	void Start () {
        i = Random.Range(0, 5);
        tracker = Instantiate(walls[i], new Vector3(-30.24f, 107.0276f, 298.74f), Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
        if (tracker.transform.position.z <= 165)
        {
            Destroy(tracker);
            destroyed = true;
        }
        if (destroyed)
        {
            i = Random.Range(0, 5);
            tracker = Instantiate(walls[i], new Vector3(-30.24f, 107.0276f, 298.74f), Quaternion.identity);
            destroyed = false;
        }
	}
}
