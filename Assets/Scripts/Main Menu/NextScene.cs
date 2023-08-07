using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour
{
    public string sceneToLoad;
    public void NewGame()
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}
