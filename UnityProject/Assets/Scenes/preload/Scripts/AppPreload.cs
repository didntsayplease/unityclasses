using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppPreload : MonoBehaviour
{
    public static AppPreload instance;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
