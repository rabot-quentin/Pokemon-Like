using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Transition : MonoBehaviour
{
    Animator animator;
    public float TransitionTime = 0.5f;
    [SerializeField] int NextScene;

    private void Aveke()
    {
        animator = GetComponent<Animator>();

    }
    public void LoadNextScene()
    {
        NextScene = SceneManager.GetActiveScene().buildIndex + 1;
        StartCoroutine(loadScene(NextScene));


    }
    IEnumerator loadScene(int buil_index)
    {
        animator.SetTrigger("out");
        yield return new WaitForSeconds(TransitionTime);
        SceneManager.LoadScene(buil_index);

    }
    
}
