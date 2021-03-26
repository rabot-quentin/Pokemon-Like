using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [Header("Sounds")]
    [SerializeField] private AudioClip CharacterSelectMusic;

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);  
    }
    public void QuitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit(); 

    }
    public void Start()
    {
        AudioManager.Instance.PlayMusicWithFade(CharacterSelectMusic);
    }
}
 