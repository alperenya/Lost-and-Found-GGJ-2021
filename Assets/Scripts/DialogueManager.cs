using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DialogueManager : MonoBehaviour
{


    public Text dialogueText;
    public void StartDialogue(Dialogue dialogue)
    {
        dialogueText.text = "You shall not pass";
    }
    public void EndDialogue()
    {
        dialogueText.text = "";
    }
}
