using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Nivel3 : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D col){
        if(col.transform.CompareTag("Player")) SceneManager.LoadScene("Nivel3");
    }
}
