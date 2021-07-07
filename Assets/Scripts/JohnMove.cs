using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JohnMove : MonoBehaviour
{
    public float JumpForce;
    public float Speed;
    private Rigidbody2D Rigidbody2D;
    private Animator Animator;
    private float Horizontal;
    private bool Grounded;
    public GameObject BulletPrefab;
    private float LastShot;
    private float Health = 10f;
    public GameObject Square;
    [SerializeField] private Bar healthBar;
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2D = GetComponent<Rigidbody2D>();
        Animator = GetComponent<Animator>();
        
    }
    public Rigidbody2D getRigidbody2D(){
        return Rigidbody2D;
    }
    public float getHorizontal(){
        return Horizontal;
    }
    public bool getGrounded(){
        return Grounded;
    }
    public float getJumpForce(){
        return JumpForce;
    }
    public float getHealth(){
        return Health;
    }

    // Update is called once per frame
    void Update()
    {
        Horizontal=Input.GetAxisRaw("Horizontal");
            
        
        if( Horizontal < 0.0f) transform.localScale = new Vector3(-1.0f , 1.0f, 1.0f);
        else if (Horizontal > 0.0f) transform.localScale= new Vector3(1.0f , 1.0f, 1.0f);

        Animator.SetBool("Running", Horizontal!= 0.0f);

        Debug.DrawRay(transform.position, Vector3.down * 0.1f, Color.red);
        if(Physics2D.Raycast(transform.position, Vector3.down, 0.1f))
        {
            Grounded = true;
        }
        else Grounded = false;
        if( Input.GetKeyDown(KeyCode.W) && Grounded){
            Jump();
        }
        if(Input.GetKey(KeyCode.Space) && Time.time > LastShot +0.25f){
            Shoot();
            LastShot = Time.time;
        }
    }
    public void FixedUpdate(){
        Rigidbody2D.velocity = new Vector2(Horizontal, Rigidbody2D.velocity.y);
    }
    private void Jump(){
        Rigidbody2D.AddForce(Vector2.up*JumpForce);
    }
    private void Shoot(){
        Vector3 direction;
        if( transform.localScale.x == 1.0f) direction = Vector2.right;
        else direction = Vector2.left;
        GameObject bullet=Instantiate(BulletPrefab, transform.position + direction *0.1f, Quaternion.identity);
        bullet.GetComponent<BulletScript>().SetDirection(direction);
    }
    public void Hit(){
        Health = Health - 1f;
        healthBar.SetSize(Health/10);
        if(Health ==0) {
            SceneManager.LoadScene("GameOver");
            Destroy(gameObject);
        }
    }
    public void DestroyJohn(){
        Destroy(gameObject);
    }
    public void getJohnInGrud(){
        
    }

}
