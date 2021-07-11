using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Vida : MonoBehaviour

{
    void OnCollisionEnter2D(Collision2D col){
        JohnMove john=col.collider.GetComponent<JohnMove>();
        if(john!=null){
            john.setHealth(10f);
        }
        DestroyVida();
    }
    public void DestroyVida(){
        Destroy(gameObject);
    }
}
