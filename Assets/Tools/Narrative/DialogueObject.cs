using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class DialogueLine
{
    [TextArea()]
    public string Line;
    public AudioClip DialogueAudio;
    public bool Unskippable = false;
}

[System.Serializable]
public class Dialogue
{

    [ListPopup(typeof(DialogueObject), "SpeakerList")]
    public string Speaker;
    public DialogueLine[] Lines;
}

[CreateAssetMenu(fileName = "Dialogue Object", menuName = "zf-tools/Narrative/Dialogue Object", order = 1)]
public class DialogueObject : ScriptableObject, ISerializationCallbackReceiver
{
    public DialogueSpeaker[] Speakers;

    public Dialogue[] Dialogues;

    private List<string> _popupList = new();
    public static List<string> SpeakerList;

    public void OnBeforeSerialize()
    {
        _popupList = GetSpeakerNames(Speakers);
        SpeakerList = _popupList;
    }

    private List<string> GetSpeakerNames(DialogueSpeaker[] speakers)
    {
        List<string> _speakers = new();

        if (speakers.Length > 0)
        {
            foreach (var speaker in speakers)
            {
                _speakers.Add(speaker.SpeakerName);
            }
        }

        return _speakers;
    }

    public void OnAfterDeserialize()
    {

    }
}


