using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PreloadImporter : MonoBehaviour
{
    private void Awake()
    {
        var preload = GameObject.Find("AppPreload");

        if(preload == null)
        {
            SceneManager.LoadScene("_preload", LoadSceneMode.Additive);
        }
    }
}
