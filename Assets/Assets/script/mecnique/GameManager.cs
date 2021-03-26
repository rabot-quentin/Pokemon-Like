using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class GameManager : MonoBehaviour
    
{
    public  static GameManager Instance;

    public  void Awake()
    {
        if (Instance != null)
        {
            return; 
        }
        Init();
        Instance = this; 
    }
    
    public Player p
    {
        get; private set; 

    }
    public Enemie e
    {
        get;private set; 
    }
    public void Init()
    {
        p = new Player();

        e = new Enemie(); 
    }

}
