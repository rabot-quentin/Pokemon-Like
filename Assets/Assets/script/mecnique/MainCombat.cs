using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI
; 
public class MainCombat : MonoBehaviour
{
    public Text text; 
    public string NomScene;
    public string NomScene1;
    public enum EtatsCombat { START,PLAYPLAYEUR,PLAYENEMIE ,LOSE ,WIN  }

    public EtatsCombat etatsCombat; 
    void Start()
    {
        etatsCombat = EtatsCombat.START;
        Duel();
        
    }
    public void Duel()
    {
        switch (etatsCombat)
        {
            case (EtatsCombat.START): 
                etatsCombat = EtatsCombat.PLAYPLAYEUR;
                GameManager.Instance.e.hp = GameManager.Instance.e.hp + 75;
                break;

            case (EtatsCombat.PLAYPLAYEUR):
                text.text = "l'adversair a " + GameManager.Instance.e.hp + "comme point de vie ";
              Debug.Log("l'adversair a " + GameManager.Instance.e.hp + "comme point de vie ");
                if (GameManager.Instance.e.hp > 0)
                {
                    etatsCombat = EtatsCombat.PLAYENEMIE; 
                }
                else
                {
                    etatsCombat = EtatsCombat.WIN; 
                }
                break;

            case (EtatsCombat.PLAYENEMIE):
                    text.text = "votre vie est de " + GameManager.Instance.p.hp + "hp ";
                    Debug.Log("votre vie est de " + GameManager.Instance.p.hp + "hp ");
                int attquAlea = Random.Range(1, 2);
                 switch (attquAlea) 
                {
                    case (1):  
                        GameManager.Instance.p.hp = GameManager.Instance.p.hp - 20;
                        break;
                    case (2):
                        GameManager.Instance.p.hp = GameManager.Instance.p.hp - 35;
                        break; 

                }
                if (GameManager.Instance.p.hp > 0 )
                {
                    etatsCombat = EtatsCombat.PLAYPLAYEUR; 
                }
                else
                {
                    etatsCombat = EtatsCombat.LOSE; 
                }
                break;
            case (EtatsCombat.WIN):
                text.text =  "vous avez surpaser l'enemie BRAVO ";
                Debug.Log("vous avez surpasser l' enemie Bravo"); 
                SceneManager.LoadScene(NomScene);
                break;
            case (EtatsCombat.LOSE):
                text.text = "l'enemie vous a etais plus fort que vous , retante ta chance une prochaine foit "; 
              Debug.Log("l'enemie vous a etais plus fort que vous , retante ta chance une prochaine foit ");
                SceneManager.LoadScene(NomScene1); 
                break;
                 
          
        }
    }      
    
}