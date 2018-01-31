using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SketchDude : MonoBehaviour {

    
    public bool hasTalked = false;

    public Dialogue dialogue;

    public DialogueManager dialogueManager;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            hasTalked = true;
        }

    }

    public void TriggerDialogue()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }

}

