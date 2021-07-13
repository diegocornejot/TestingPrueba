using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arma : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D col){
        JohnMove john=col.collider.GetComponent<JohnMove>();
        if(john!=null){
            john.setVeloDisparo(0.15f);
        }
        DestroyArma();
    }
    public void DestroyArma(){
        Destroy(gameObject);
    }
}
