using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformStick : MonoBehaviour {

    public GameObject player;
    public GameObject buffer;
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            buffer.transform.parent = transform;
            player.transform.parent = buffer.transform;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == player)
        {
            buffer.transform.parent = null;
            player.transform.parent = null;
        }
    }
}
