using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathTrigger : MonoBehaviour {

	// This code is a simple "teleport to last location death" 
	// When an object with this code is hit, 
	// player returns to given "save point".
	[SerializeField] public float m_x;
	[SerializeField] public float m_y;
	[SerializeField] public float m_z;

	void OnTriggerEnter(Collider enter)
	{
		Debug.Log("Trigger hit!");

		enter.gameObject.transform.position = new Vector3(m_x, m_y, m_z); 
	}
}
