using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DialogueUI : MonoBehaviour
{
    [Header("UI")]
    [SerializeField] TextMeshProUGUI _dTextUI;
    [SerializeField] TextMeshProUGUI _dSpeakerNameUI;
    [SerializeField] Image _dSpeakerImageUI;
    [SerializeField][Tooltip("Line speed in characters per second")] float _lineSpeed = 10;

    private Coroutine _activeDialogue;

    #region Singleton stuff
    public static DialogueUI Instance { get; private set; }
    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
    }
    #endregion

    public void StartDialogue(DialogueObject dialogueFile)
    {
        StopCoroutine(_activeDialogue);
        // _activeDialogue = StartCoroutine(ProcessDialogue(dialogueFile));
    }

    // private IEnumerator ProcessDialogue(DialogueObject dialogueFile)
    // {

    // }
}

