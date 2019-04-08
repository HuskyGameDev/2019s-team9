﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    /// <summary>
    /// Loads the scene.
    /// The scene indexes are as follows (Subject to change as production progresses):
    ///     MainMenu    = 0
    ///     LevelSelect = 1
    ///     QuitGame    = 2
    ///     Gameplay    = 3
    /// </summary>
    /// <param name="scene_index">Scene index.</param>
    public void LoadScene (int scene_index)
    {
        SceneManager.LoadScene (scene_index);
    }

    /// <summary>
    /// Quits the game.
    /// </summary>
    public void QuitGame()
    {
        Application.Quit();
    }

    public GameManager GM;
	
	// Update is called once per frame
	void Update ()
	{
	    if (Input.GetButtonDown("Cancel"))     
		{
			GM.TogglePauseMenu();
		}
    }



}