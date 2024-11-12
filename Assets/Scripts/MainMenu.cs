using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    int currentSceneIndex;

    public void LoadNextLevel()
    {
        // SceneManager.sceneCountInBuildSettings - 1 is the index of the last scene
        if (currentSceneIndex < SceneManager.sceneCountInBuildSettings - 1)
        {
            SceneManager.LoadScene(currentSceneIndex + 1);
        }
        else if (currentSceneIndex == SceneManager.sceneCountInBuildSettings - 1)
        {
            // load first scene (restart game)
            SceneManager.LoadScene(0);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
