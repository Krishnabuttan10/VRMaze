using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
public class Timer : MonoBehaviour
{
    public GameObject gameover;
    public TextMeshProUGUI timer;
    int countdown=300;
    float wait;

    public void CountDown()
    {
        if (countdown > 0)
        {
            TimeSpan sptime = TimeSpan.FromSeconds(countdown);
            timer.text =  sptime.Minutes + ":" + sptime.Seconds;
            countdown--;

        }
        else if (countdown <= 0)
        {
            gameover.SetActive(true);
        }

    }
    public void tryagain()
    {
        gameover.SetActive(false);
        SceneManager.LoadScene("maze");
    }

    private void Update()
    {
        if (wait == 0)
        {
            wait = 1;
            CountDown();
        }
        else
        {
            wait -= Time.deltaTime;
            if (wait < 0)
            {
                wait = 0;
            }

        }

    }

    public void back()
    {
        SceneManager.LoadScene("home");
    }
}
