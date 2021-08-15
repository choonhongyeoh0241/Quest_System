using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestManager : MonoBehaviour
{
    public Quest currentQuest;
    public List<GameObject> statusMarkers;
    private void Awake()
    {
        UpdateStatus();
    }
    public void UpdateStatus()
    {
        print("Updated");
        foreach (GameObject statusMarker in statusMarkers)
        {
            if(currentQuest.arrayIdx == statusMarkers.IndexOf(statusMarker))
            {
                statusMarker.SetActive(true);
            }
            else
            {
                statusMarker.SetActive(false);
            }
        }
    }
    
}
