using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityDisabler : MonoBehaviour
{
    private bool showText = false, someRandomCondition = true;
    private float currentTime = 0.0f, executedTime = 0.0f, timeToWait = 2.0f;
     
    void Start()
    {
        executedTime = Time.time;
    }
    
    void Update()
    {
		if (Input.GetKeyDown(KeyCode.Q))     
		{
			executedTime = Time.time;
		}
        
		currentTime = Time.time;
        
		if(currentTime - executedTime > timeToWait)
        {
            someRandomCondition = false;
        }
		
        if(someRandomCondition)
            showText = true;
        else
            showText = false;
		
    }
     
    void OnGUI()
    {
        if(showText)
            GUI.Label(new Rect(0, 0, 100, 100), "Super Jump Disabled");
    }
}
