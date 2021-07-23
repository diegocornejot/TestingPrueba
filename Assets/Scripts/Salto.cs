using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Salto : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D col){
        JohnMove john=col.collider.GetComponent<JohnMove>();
        if(john!=null){
            john.setJumpForce(200f);
        }
        DestroySalto();
    }
    public void DestroySalto(){
        Destroy(gameObject);
    }
}
