using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCController : MonoBehaviour, Interactable
{
    [SerializeField] Dialogue dialogue;

    public void Interact()
    {
        StartCoroutine(DialogManager.Instance.ShowDialogue(dialogue));
    }
}
