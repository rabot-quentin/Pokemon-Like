using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour
{
    public GameObject[] objects ; 
    private void Awake()
    {
        foreach(var element in objects)
        {
            DontDestroyOnLoad(element); 
        }
    }
}
