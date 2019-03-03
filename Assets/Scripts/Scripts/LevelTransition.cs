using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelTransition : MonoBehaviour
{
    /// <summary>
    /// Loads the scene.
    /// The scene indexes are as follows:
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


    int index = -1;

    void Start() {
        index = SceneManager.GetActiveScene().buildIndex;

    }

    void OnTriggerEnter() {

        print(index);
        if (index == 0)
            SceneManager.LoadScene (1);
        else if (index == 1)
            SceneManager.LoadScene (0);
    }



}