using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    // Public variable to set the scene index through the Unity Inspector
    public int sceneIndex;

    // Method to change the scene
    public void ChangeScene()
    {
        SceneManager.LoadScene(sceneIndex);
    }
}
