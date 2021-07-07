using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bar : MonoBehaviour
{
    private Transform bar;
    // Start is called before the first frame update
    private void Start()
    {
        Transform bar=transform.Find("Bar");
        bar.localScale = new Vector3(1f,1f);
        
    }

    public void SetSize(float sizeNormalized){
        Transform bar=transform.Find("Bar");
        bar.localScale= new Vector3(sizeNormalized,1f);
    }
}
