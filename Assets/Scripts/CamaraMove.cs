using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraMove : MonoBehaviour
{
    public GameObject john;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(john!=null){
            Vector3 position = transform.position;
            position.x = john.transform.position.x;
            transform.position = position;
        }
    }
}
