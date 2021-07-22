using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public AudioClip Sound;
    public float Speed;
    // Start is called before the first frame update
    private Rigidbody2D Rigidbody2D;
    private Vector2 Direction;
    void Start()
    {
        Rigidbody2D = GetComponent<Rigidbody2D>();
        Camera.main.GetComponent<AudioSource>().PlayOneShot(Sound);
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        Rigidbody2D.velocity = Direction * Speed;
    }
    public void SetDirection(Vector2 direction){
        Direction = direction;
    }
    public void DestroyBullet(){
        Destroy(gameObject);
    }
    private void OnTriggerEnter2D(Collider2D collision){
        JohnMove john= collision.GetComponent<JohnMove>();
        GrudScript grunt = collision.GetComponent<GrudScript>();
        Boss boss = collision.GetComponent<Boss>();
        if(john!=null){
            john.Hit();
        }
        if(grunt!=null){
            grunt.Hit();
        }
        if(boss!=null){
            boss.Hit();
        }
        DestroyBullet();
    }
}
