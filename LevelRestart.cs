using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//3

public class LevelRestart : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)//1
    {
        if (other.CompareTag("Player"))//2
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);//4- Mevcut sahneyi ismiyle load ediyoruz.
        }
    }
}
