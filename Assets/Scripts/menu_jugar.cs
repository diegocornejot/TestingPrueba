using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using System.Threading;

public class menu_jugar : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }

    public void LoadGame()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
