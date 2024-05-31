using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialogo : MonoBehaviour
{
    private bool isPlayerInRange;
    private bool DidDialogoStart;
    private int lineIndex;
    private float timingtiempo = 0.05f;
    [SerializeField,TextArea(4,6)] private string[] dialogoLines;
    [SerializeField] private TMP_Text dialogueText;
    [SerializeField] private GameObject dialogoPanel;

    // Update is called once per frame
    void Update()
    {
        if (isPlayerInRange && Input.GetButtonDown("Fire2"))
        {
            if (!DidDialogoStart)
            { 
                StartDialogo();
            }
            else if (dialogueText.text == dialogoLines[lineIndex])
            {
                NextDialogoLine();
            }
            else
            {
                StopAllCoroutines();
                dialogueText.text = dialogoLines[lineIndex];
            }
           
        }
    }

    private void StartDialogo()
    { 
        DidDialogoStart = true;
        dialogoPanel.SetActive(true);
        lineIndex=0;
        Time.timeScale = 0f;
        StartCoroutine(ShowLine());
    }

    private void NextDialogoLine()
    {
        lineIndex++;
        if(lineIndex < dialogoLines.Length)
        {
            StartCoroutine(ShowLine());
        }
        else
        {
            DidDialogoStart=false;
            dialogoPanel.SetActive(false);
            Time.timeScale=1f;
              
        }
    }

    private IEnumerator ShowLine()
    {
        dialogueText.text=string.Empty;

        foreach(char ch in dialogoLines[lineIndex])
        {
            dialogueText.text+=ch;
            yield return new WaitForSecondsRealtime(timingtiempo);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        isPlayerInRange=true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        isPlayerInRange=false;
    }


}
