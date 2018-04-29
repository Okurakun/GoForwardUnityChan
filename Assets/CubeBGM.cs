using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeBGM : MonoBehaviour {
    
    
	void Start () {
        

       
    }
	
	// Update is called once per frame
	void Update () {
        
    }
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "ground")
        {
            AudioSource audio = GetComponent<AudioSource>();
            audio.Play();
        }
            

    }
}
