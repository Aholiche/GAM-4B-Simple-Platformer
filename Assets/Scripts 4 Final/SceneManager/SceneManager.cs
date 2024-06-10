using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManager : MonoBehaviour
{
    int savedScene;
    int SceneIndex;

    //LoadSyncAsync hasn't been defined so commented out.

    public void SaveScene()
    {
        //SceneManager.LoadSceneAsync(1);
    }

    public void LoadScene()
    {
        savedScene = PlayerPrefs.GetInt("Saved");

        /*
        if (savedScene != 0)
            SceneManager.LoadSceneAsync(savedScene);
        else
            return;*/
    }
}
