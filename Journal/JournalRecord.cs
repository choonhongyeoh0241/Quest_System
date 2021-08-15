using UnityEngine;
using UnityEngine.UI;

public class JournalRecord : MonoBehaviour
{
    public Quest recordedQuest;

    public Text recordedQuestTitleText;
    public Image recordedQuestGiverIcon;
    public Text recordedQuestStatus;

    private void Awake()
    {
        NewRecord();
    }
    public void NewRecord()
    {
        recordedQuestTitleText.text = recordedQuest.questTitle;
        recordedQuestGiverIcon.sprite = recordedQuest.questGiver;
        recordedQuestStatus.text = recordedQuest.questStatus[recordedQuest.arrayIdx];
    }
    public void EmptyRecord()
    {
        Destroy(gameObject);
    }
}
