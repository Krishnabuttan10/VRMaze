using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class gameplay : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(Wait());
    }
    IEnumerator Wait()
    {
        yield return new WaitForSeconds(3f);
        Debug.Log("Level Enter");
       
        SceneManager.LoadScene("note");
    }
    public void play()
    {
        SceneManager.LoadScene("note");        
    }

    public void exit()
    {
        Application.Quit();
    }   
}
