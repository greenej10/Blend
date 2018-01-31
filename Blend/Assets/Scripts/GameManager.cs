using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public GameObject player;
    public bool invincible = false;
    public int health = 100;
    public int bullets = 12;


    public void InShadow()
    {
        invincible = true;
    }

    public void OutShadow()
    {
        invincible = false;
    }

	
}
