using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour, IInteractable
{
    public DialogueObject DialogueFile;

    [SerializeField]
    private GameObject _dialogueUI;

    void Start()
    {
        _dialogueUI.SetActive(false);
    }

    public void Interact()
    {
        _dialogueUI.SetActive(true);
        DialogueUI.Instance.StartDialogue(DialogueFile);
    }

}
