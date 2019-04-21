using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finalTrigger : MonoBehaviour {

    public GameObject player;
    public GameObject secretDoor;
    public GameObject wall;
    private GameObject wallBuff;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            Instantiate(wall, new Vector3(53.43f, 221.02f, 511.53f), Quaternion.identity);
            Destroy(secretDoor);
        }
    }
}
