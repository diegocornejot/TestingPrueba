using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    [HideInInspector]
    public bool mustPatrol;
    public float walkSpeed;
    public GameObject john;
    private float LastShot;
    public GameObject BulletPrefab;
    private int Health=3;
    public Rigidbody2D rb;
    private bool mustTurn;
    public Transform groundCheckPos;
    public LayerMask groundLayer;
    public Collider2D bodyCollider;

    public GameObject getJohn(){
        return john;
    }
    public bool getMustPatrol(){
        return mustPatrol;
    }
    public void setWalkSpeed(float nuevo){
        walkSpeed= nuevo;
    }
    void Start(){
        mustPatrol = true;
    }
    public void Update(){
        if(john==null) return;

        Vector3 direction = john.transform.position - transform.position;
        //if (direction.x >= 0.0f) transform.localScale = new Vector3(1.0f, 1.0f , 1.0f);
        //else transform.localScale = new Vector3(-1.0f, 1.0f, 1.0f);

        float distance = Mathf.Abs(john.transform.position.x - transform.position.x);
        float distancey = Mathf.Abs(john.transform.position.y - transform.position.y);
        if(distance < 1.0f && Time.time > LastShot + 0.25f && distancey < 0.5f)
        {
            mustPatrol=false;
            if (direction.x >= 0.0f) transform.localScale = new Vector3(1.0f, 1.0f , 1.0f);
            else transform.localScale = new Vector3(-1.0f, 1.0f, 1.0f);
            Shoot();
            LastShot = Time.time;
        }
        if (mustPatrol){
            Patrol();
        }
    }
    void FixedUpdate(){
        if(mustPatrol){
            mustTurn= !Physics2D.OverlapCircle(groundCheckPos.position, 0.1f, groundLayer);
        }
    }
    private void Shoot(){
        Vector3 direction;
        if( transform.localScale.x == 1.0f) direction = Vector2.right;
        else direction = Vector2.left;
        Vector3 nuevo=Vector2.down*0.2f;
        Debug.Log(nuevo);
        GameObject bullet=Instantiate(BulletPrefab, transform.position + direction *0.2f+nuevo, Quaternion.identity);
        bullet.GetComponent<BulletScript>().SetDirection(direction);
    }
    public void Hit(){
        Health = Health - 1;
        if(Health ==0) Destroy(gameObject);
    }
    public void Patrol(){
        
        if(mustTurn || bodyCollider.IsTouchingLayers(groundLayer)){
            Flip();
        }
        rb.velocity= new Vector2(walkSpeed * Time.fixedDeltaTime, rb.velocity.y);
    }
    public void Flip(){
        mustPatrol = false;
        transform.localScale = new Vector2(transform.localScale.x * -1,transform.localScale.y);
        walkSpeed *=-1;
        mustPatrol = true;
    }
    public float getHealth(){
        return Health;
    }
}
