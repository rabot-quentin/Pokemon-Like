using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class ChangMap : MonoBehaviour
{
    public string NomScn;
    public Animator fadSystem; 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {

            StartCoroutine(loadNextScene());
        }
    }
    public IEnumerator loadNextScene()
    {
        fadSystem.SetTrigger("FadIn");
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(NomScn);

    }
}
