using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Combat : MonoBehaviour
{
    public void AttakNorm()
    {
        GameManager.Instance.e.hp = GameManager.Instance.e.hp - 10; 
    }
    public void AttakSpec()
    {
        GameManager.Instance.e.hp = GameManager.Instance.e.hp - 25; 
    }
}
