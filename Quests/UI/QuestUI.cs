using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class QuestUI : MonoBehaviour
{
    public Text questDescription;
    public Image questGiverIcon;
    public QuestManager questManager;
    public GameObject questUI;
    public Journal journal;

    private void Update() 
    {
        //Возможно стоит убрат ьи работаьть только с Show и Hide
        if(questManager != null)
        {
            ShowQuest();
        }
        else
        {
            HideQuest();
        }
    }
    public void ShowQuest()
    {
        questUI.SetActive(true);
        if(questManager.currentQuest.arrayIdx == 0)
        {
            questDescription.text = questManager.currentQuest.questDescription;
            questGiverIcon.sprite = questManager.currentQuest.questGiver;
        }
        else if(questManager.currentQuest.arrayIdx == 1)
        {
            questDescription.text = questManager.currentQuest.inProgressText;
            questGiverIcon.sprite = questManager.currentQuest.questGiver;
        }
        else
        {
            questDescription.text = questManager.currentQuest.finalText;
            questGiverIcon.sprite = questManager.currentQuest.questGiver;
        }
    }
    public void HideQuest()
    {
        questUI.SetActive(false);
        questManager = null;
        questDescription.text = null;
        questGiverIcon.sprite = null;
    }
    public void TakeQuest()
    {
        questManager.currentQuest.QuestConfirmed();
        questManager.UpdateStatus();
        List<Quest> recordedToJournal = new List<Quest>();
        recordedToJournal.Add(questManager.currentQuest);
        journal.AddRecords(recordedToJournal);
        HideQuest();
    }
    public void IgnoreQuest()
    {
        HideQuest();
    }
}
