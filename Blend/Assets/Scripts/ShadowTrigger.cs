using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShadowTrigger : MonoBehaviour {

    public GameManager gameManager;


    private void OnTriggerEnter2d(Collider other)
    {
            gameManager.invincible=true;
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        gameManager.invincible = false;
    }


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
