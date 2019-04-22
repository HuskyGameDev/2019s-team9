using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetBlock : MonoBehaviour {

	public GameObject block;
	public GameObject player;

	private void OnTriggerEnter(Collider other) {
		if(other.gameObject == player)
			block.transform.position = new Vector3(0.2f,99.1f,520.28f);
	}
}
