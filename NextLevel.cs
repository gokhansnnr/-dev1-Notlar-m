using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//3

public class NextLevel : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)//1
    {
        if (other.CompareTag("Player"))//2
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);//4
        }
    }

    public void next()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);//5
    }
}
