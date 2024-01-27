using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private AudioClip clickSound; //7
    private int count=0; //4

    private void OnTriggerEnter2D(Collider2D other) //1
    {
        if(other.gameObject.CompareTag("Collectible")) //2
        {
            Debug.Log(count);//6
            count++; //5
            AudioSource.PlayClipAtPoint(clickSound, other.transform.position); //8- Sesi bir kez, çarptýðýmýz yerin pozisyonunda çalacaðýz.
            Destroy(other.gameObject);//3
        }
    }
}
