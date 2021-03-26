using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerSelected : MonoBehaviour
{
   
    private int selectedCharacterIndex;
    private Color desiredColor;
    public int ChoixPerso; 
    public string NomScene1;
    public string NomScene2;
    public string NomScene3;

    [Header("List of characters")]
    [SerializeField] private List<CharacterSelectObject> characterList = new List<CharacterSelectObject>(); 

    [Header("UI Renferences")]
    [SerializeField] private TextMeshProUGUI characterName; 
    [SerializeField] private Image charcterSplash ;
    [SerializeField] private Image backgroundColor;

    [Header("Sounds")]
    [SerializeField] private AudioClip arrowClikSFX;
    [SerializeField] private AudioClip Music; 



    private void Start()
    {
        
        UpdateCharacterSelectionUI();
        AudioManager.Instance.PlayMusicWithFade(Music); 
    }
   
    public void LeftArrow()
    {
        selectedCharacterIndex--;
        if (selectedCharacterIndex < 0) 
        {
            selectedCharacterIndex = characterList.Count - 1;
            
        }
        UpdateCharacterSelectionUI();
        AudioManager.Instance.PlaySFX(arrowClikSFX);
    }
    public void RigthArrow()
    {
        selectedCharacterIndex++;
        if (selectedCharacterIndex == characterList.Count )
        {
            selectedCharacterIndex = 0;
           
        }
        UpdateCharacterSelectionUI();
        AudioManager.Instance.PlaySFX(arrowClikSFX);
    }
    public void Confirm()
    {

       
        Debug.Log(string.Format("Character {0}:{1}has been chosen", selectedCharacterIndex, characterList[selectedCharacterIndex].characterName));
        
        if (characterList[selectedCharacterIndex].characterName == "Babar")
        {        
        SceneManager.LoadScene(NomScene2);
        }
        else if ((characterName.text == "Zombie"))
        {
            SceneManager.LoadScene(NomScene3);
        }
        else if ((characterName.text == "Dragon"))
        {
            SceneManager.LoadScene(NomScene1);
        }




    }

    private void UpdateCharacterSelectionUI()
    {
        
        charcterSplash.sprite = characterList[selectedCharacterIndex].splash;
        characterName.text = characterList[selectedCharacterIndex].characterName;
        
       
    }
    [System.Serializable]
    public class CharacterSelectObject
    {
        public Sprite splash;
        public string characterName;
       
    }
}
