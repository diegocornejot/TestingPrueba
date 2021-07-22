using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VideoPLayer : MonoBehaviour
{
    public GameObject videoPlayer;
    public int timeToStop;

	// Use this for initialization
	void Start () {
        videoPlayer.SetActive(false);
	}
	
	// Update is called once per frame
    void OnCollisionEnter2D(Collision2D col){
        JohnMove john=col.collider.GetComponent<JohnMove>();
        if(john!=null){
            videoPlayer.SetActive(true);
            Destroy(videoPlayer, timeToStop);
        }
    }
}
