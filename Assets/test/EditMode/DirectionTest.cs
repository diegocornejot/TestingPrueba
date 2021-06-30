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
        Assert.IsTrue(objeto != null);
    }

}
