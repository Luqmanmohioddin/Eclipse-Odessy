using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine.UI;

public class CutsceneDialogManager : MonoBehaviour
{
    public GameObject dialogBox;
    public TMP_Text dialogText;
    public string fullText;
    public float textSpeed = 40.0f;

    private int textIndex = 0;
    private float textTimer = 0.0f;
    private bool isDisplayingText = false;

    private void Update()
    {
        if (isDisplayingText == true)
        {
            textTimer += Time.deltaTime;

            if (textTimer >= 1.0f / textSpeed)
            {
                textIndex++;
                dialogText.text = fullText.Substring(0, textIndex);
                textTimer = 0.0f;

                if (textIndex >= fullText.Length)
                {
                    isDisplayingText = false;
                    EndDialogue();
                }
            }
        }
    }

    public void StartDialogue(string text)
    {
        fullText = text;
        textIndex = 0;
        dialogText.text = "What Just Happend?";
        dialogBox.SetActive(true);
        isDisplayingText = true;
    }

    public void EndDialogue()
    {
        dialogBox.SetActive(false);
    }
}
