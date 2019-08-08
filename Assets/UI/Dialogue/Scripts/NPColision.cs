﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPColision : MonoBehaviour
{
    private NPCDialogueTriger _dialogueTriger;

    private DialogueManager _dialogueManager;

    private void Start()
    {
        _dialogueTriger = GetComponent<NPCDialogueTriger>();
        _dialogueManager = FindObjectOfType<DialogueManager>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //9 - player layer
        if (collision.gameObject.layer == 9)
        {
            _dialogueTriger.TriggerDialogue();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 9)
        {
            _dialogueManager.EndDialogue();
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetKeyDown(KeyCode.C) && collision.gameObject.layer == 9)
        {
            _dialogueManager.DisplayNextSentence();
        }
    }
}
