using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShadowTrigger : MonoBehaviour
{

    public GameManager gameManager;
    public bool inShadow;


    void OnTriggerEnter2d(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            gameManager.InShadow();
            inShadow = true;

            Debug.Log("IN SHADOW");
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            gameManager.OutShadow();
            inShadow = false;
            Debug.Log("LEFT SHADOW");
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            gameManager.InShadow();
            inShadow = true;

            Debug.Log("IN SHADOW");

        }



    }
}
