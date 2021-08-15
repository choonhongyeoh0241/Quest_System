using System.Security.Cryptography.X509Certificates;
using UnityEngine;

[CreateAssetMenu (fileName = "NewQuest", menuName ="Events/Quest")]
public class Quest : ScriptableObject
{
    public string questTitle;
    public string questDescription;
    public string inProgressText;
    public string finalText;
    [HideInInspector]
    public int arrayIdx = 0;
    [HideInInspector]
    public string[] questStatus = new string[] {"NewQuestMark","ActiveQuestMark","DoneQuestMark"};
    public Sprite questGiver;

    public void QuestConfirmed()
    {
        arrayIdx=1;
    }
}
