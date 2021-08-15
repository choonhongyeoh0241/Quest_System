using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderTrigger : MonoBehaviour
{
    [SerializeField] private Collider2D playerCol;
    [SerializeField] private QuestUI questUI;
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D col) 
    {

        if(col.GetComponent<QuestManager>())
        {
            Quest curQuest = col.GetComponent<QuestManager>().currentQuest;
            questUI.questManager = col.GetComponent<QuestManager>();
        }
    }
    private void OnTriggerExit2D(Collider2D col) 
    {
        if(col.GetComponent<QuestManager>())
        {
            questUI.HideQuest();
        }
    }
}
