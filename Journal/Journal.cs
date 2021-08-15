using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Journal : MonoBehaviour
{
    public List<JournalRecord> records;
    public List<Quest> quests;
    public GameObject journalUI;
    public GameObject JournalActivePage;
    public GameObject newRecordPrefab;
    private bool showJournalUI = false;
    private void Start()
    {
        records = new List<JournalRecord>();
        StartRecord();
    }
    private void Update() 
    {
        if(Input.GetKeyDown(KeyCode.T))
        {
            ShowJournalUI();
        }
    }
    public void ShowJournalUI()
    {
        if(showJournalUI!=true)
        {
            journalUI.SetActive(true);
            showJournalUI = true;
        }
        else
        {
            journalUI.SetActive(false);
            showJournalUI = false;
        }
    }
    public void StartRecord()
    {
        while(quests.Count>=records.Count+1)
        {
            JournalRecord newRecord = Instantiate(newRecordPrefab.GetComponent<JournalRecord>(), JournalActivePage.transform);
            records.Add(newRecord);
            for (int i = 0; i < records.Count ; i++)
            {
                records[i].recordedQuest = quests[i];
                records[i].NewRecord();
            }
        }
        for (int i = 0; i < quests.Count ; i++)
        {
            records[i].recordedQuest = quests[i];
            records[i].NewRecord();
            // curWeight+=items[i].itemWeight;
        }
    }
    public void AddRecords(List<Quest> newQuests)
    {
        if(quests.Count>=records.Count)
        {
            foreach(Quest newQuest in newQuests)
            {
            // if (!newQuest.isDefault)
            // {
                JournalRecord newRecord = Instantiate(newRecordPrefab.GetComponent<JournalRecord>(), JournalActivePage.transform);
                records.Add(newRecord);
                quests.Add(newQuest);
                newRecord.recordedQuest = newQuest;
                newRecord.NewRecord();
                // curWeight+=newItem.itemWeight;
            // }
            }
        }
        for (int i = 0; i < quests.Count ; i++)
        {
            // if (!records[i].recordedQuest.isDefault)
            // {
            records[i].recordedQuest = quests[i];
            records[i].NewRecord();
            // }
        }
    }
    public void dellItem(Quest removeQuest)
    {
        // quests.Remove(delItem);
        // records.Remove(curSlot);
        // curWeight-=delItem.itemWeight;
    }
}
