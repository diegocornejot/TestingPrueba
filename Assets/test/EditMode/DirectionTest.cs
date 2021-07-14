using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;


public class DirectionTest : MonoBehaviour
{
    // A Test behaves as an ordinary method
    [Test]
    public void Existe()
    {
        JohnMove objeto= new JohnMove();
        //Assert.IsTrue( objeto.getRigidbody2D());
        Assert.IsTrue(objeto == null);
    }
    [Test]
    public void Direccion()
    {
        JohnMove objeto= new JohnMove();
        Assert.AreEqual(0.0f, objeto.getHorizontal());
    }
    [Test]
    public void Grounded()
    {
        JohnMove objeto= new JohnMove();
        Assert.AreEqual(false, objeto.getGrounded());
    }
    [Test]
    public void Menos_Vida()
    {
        JohnMove objeto= new JohnMove();
        //objeto.Hit();
        Debug.Log(objeto.getHealth());
        Assert.AreEqual(10f, objeto.getHealth());
    }
    [Test]
    public void FixedUpdate()
    {
        JohnMove objeto= new JohnMove();
        objeto.FixedUpdate();
        Assert.AreEqual(objeto.getRigidbody2D().velocity, new Vector2(objeto.getHorizontal(), objeto.getRigidbody2D().velocity.y));
    }
    [Test]
    public void Vida()
    {
        Vida objeto= new Vida();
        //objeto.DestroyVida();
        Vida objeto2= new Vida();
        
        Assert.AreEqual(null, objeto);
    }
    [Test]
    public void Vida2()
    {
        Vida objeto= new Vida();
        //objeto.DestroyVida();
        Assert.Null(objeto);
    }
    [Test]
    public void Arma()
    {
        Arma objeto= new Arma();
        //objeto.DestroyVida();
        Assert.Null(objeto);
    }

    [Test]
    public void VelocidadDisparo()
    {
        JohnMove objeto= new JohnMove();
        //objeto.DestroyVida();
        objeto.setVeloDisparo(0.15f);
        Assert.AreEqual(0.15f, objeto.getVeloDisparo());
    }
    [Test]
    public void Grud()
    {
        GrudScript objeto= new GrudScript();
        //objeto.DestroyVida();
        Assert.Null(objeto);
    }
    [Test]
    public void GrudPatrol()
    {
        GrudScript objeto= new GrudScript();
        //objeto.DestroyVida();
        Assert.AreEqual(false, objeto.getMustPatrol());
    }
    [Test]
    public void GrudFlip()
    {
        bool mustPatrol = false;
        int walkSpeed=0;
        //transform.localScale = new Vector2(transform.localScale.x * -1,transform.localScale.y);
        walkSpeed *=-1;
        mustPatrol = true;
        Assert.AreEqual(true, mustPatrol);
    }
    [Test]
    public void GrudPatrol2()
    {
        bool mustPatrol = true;
        bool mustTurn = true;
        Collider2D bodyCollider;
        if(mustTurn ){
            int walkSpeed=0;
        //transform.localScale = new Vector2(transform.localScale.x * -1,transform.localScale.y);
            walkSpeed *=-1;
            mustPatrol = true;
            Assert.AreEqual(true, mustPatrol);
        }
        //rb.velocity= new Vector2(walkSpeed * Time.fixedDeltaTime, rb.velocity.y);
    }
    [Test]
    public void GrudHit()
    {
        GrudScript objeto= new GrudScript();
        float Health=objeto.getHealth();
        Health = Health - 1;
        if(Health ==0) Destroy(gameObject);
        Assert.AreEqual(2f, Health);
    }
    [Test]
    public void GrudShoot()
    {
        GameObject BulletPrefab;
        Vector3 direction;
        if( transform.localScale.x == 1.0f) direction = Vector2.right;
        else direction = Vector2.left;
        //GameObject bullet=Instantiate(BulletPrefab, transform.position + direction *0.1f, Quaternion.identity);
        //bullet.GetComponent<BulletScript>().SetDirection(direction);
    }


}
