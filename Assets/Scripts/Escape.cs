using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Escape : MonoBehaviour {

	public float sleepTime = 3f;

	private float time1 = 0f;
	private float time2 = 0;

	private bool pressedOnce = false;

	// Use this for initialization
	void Start () {
			
	}
	
	// Update is called once per frame
	void Update () {

		if(pressedOnce && Time.time - time1 <= 3f && Input.GetKeyDown(KeyCode.Escape))
			SceneManager.LoadScene("Main Menu");

		if(time1 == 0f && Input.GetKeyDown(KeyCode.Escape))
		{
			pressedOnce = true; 
			time1 = Time.time;
			
		}
		


		

		if(Time.time - time1 >= 3f)
		{
			time1 = 0f;
			pressedOnce = false;
		}
			
	}
}
