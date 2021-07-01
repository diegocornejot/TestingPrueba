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
    public void Health()
    {
        JohnMove objeto= new JohnMove();
        Assert.AreEqual(5, objeto.getHealth());
    }
    [Test]
    public void Menos_Vida()
    {
        JohnMove objeto= new JohnMove();
        objeto.Hit();
        Assert.AreEqual(4, objeto.getHealth());
    }
    [Test]
    public void FixedUpdate()
    {
        JohnMove objeto= new JohnMove();
        objeto.FixedUpdate();
        Assert.AreEqual(objeto.getRigidbody2D().velocity, new Vector2(objeto.getHorizontal(), objeto.getRigidbody2D().velocity.y));
    }

}
