using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
[CreateAssetMenu(fileName = "Dialogue Speaker", menuName = "zf-tools/Narrative/Speaker", order = 0)]
public class DialogueSpeaker : ScriptableObject
{
    public string SpeakerName;
    public Sprite Image;


}
