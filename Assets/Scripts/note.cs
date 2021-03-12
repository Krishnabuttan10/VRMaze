using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class note : MonoBehaviour
{
    public GameObject note1;
    void Start()
    {
        note1.SetActive(true);
        StartCoroutine(Wait());
    }
    IEnumerator Wait()
    {
        yield return new WaitForSeconds(2f);
        Debug.Log("Level Enter");
        note1.SetActive(false);
        SceneManager.LoadScene("maze");
    }
}
