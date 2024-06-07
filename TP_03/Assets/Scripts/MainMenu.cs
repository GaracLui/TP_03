using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Empieza nivel 1
    public void ScenePlay()
    {
        SceneManager.LoadScene("Scene_1");
    }

    public void ExitPlay()
    {
        // Cuando esta compilada
        Application.Quit();

        // Si estas en el editor de Unity
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #endif
    }
}