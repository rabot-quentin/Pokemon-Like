using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AleatoirComb : MonoBehaviour
{
    public string NomCOmbat1;
    public string NomCOmbat2;
    public string NomCOmbat3;
    public string NomCOmbat4;
    public Animator fadSystem;
   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {

            StartCoroutine(loadNextCombat());
        }
    }
    public IEnumerator loadNextCombat()
    {
        fadSystem.SetTrigger("FadIn");
        yield return new WaitForSeconds(1f);
        int SceneCombat = Random.Range(0, 3);
        switch (SceneCombat)
        {
            case (0):
                SceneManager.LoadScene(NomCOmbat1);
                break;
            case (1):
                SceneManager.LoadScene(NomCOmbat2);
                break;
            case (2):
                SceneManager.LoadScene(NomCOmbat3);
                break;
            case (3):
                SceneManager.LoadScene(NomCOmbat4);
                break;
        }


    }
}
