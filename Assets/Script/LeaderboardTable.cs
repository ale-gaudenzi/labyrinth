using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LeaderboardTable : MonoBehaviour {

    private Transform entryContainer;
    private Transform entryTemplate;
    private List<Transform> scoreEntryTransformList;
    
    private void Awake() { 
        entryContainer = transform.Find("LeaderboardPanel");
        entryTemplate = entryContainer.Find("EntryTemplate");

        entryTemplate.gameObject.SetActive(false);

        if(!PlayerPrefs.HasKey("scoreTable")) {
            DefaultScoreTable();
        }

        //AddEntry("aaa", 20.00f, 2);
        //AddEntry("bbb", 2.341f, 0);
        //AddEntry("vvv", 12.312f, -2);
        string jsonString = PlayerPrefs.GetString("scoreTable");
        Scores scores = JsonUtility.FromJson<Scores>(jsonString);

        for (int i = 0; i < scores.scoreEntryList.Count; i++) {
            for (int j = i+1; j < scores.scoreEntryList.Count; j++) {
                if(scores.scoreEntryList[j].time < scores.scoreEntryList[i].time) {
                    ScoreEntry tmp = scores.scoreEntryList[i];
                    scores.scoreEntryList[i] = scores.scoreEntryList[j];
                    scores.scoreEntryList[j] = tmp;
                }
            }
        }

        scoreEntryTransformList = new List<Transform>();

        for(int i = 0; i < 10 && i < scores.scoreEntryList.Count; i++)  {
            CreateScoreEntryTransform(scores.scoreEntryList[i], entryContainer, scoreEntryTransformList);
        }
    }


    private void CreateScoreEntryTransform(ScoreEntry scoreEntry, Transform container, List<Transform> transformList) {
        float templateHeight = 80f; 
        Transform entryTransform = Instantiate(entryTemplate, entryContainer);
        RectTransform entryRectTransform = entryTransform.GetComponent<RectTransform>();
        entryRectTransform.anchoredPosition = new Vector2(0, -templateHeight * transformList.Count);
        entryTransform.gameObject.SetActive(true);
    
        int rank = transformList.Count + 1;
        string rankString;
        switch(rank) {
            default: rankString = rank + "TH"; break;
            case 1: rankString = "1ST"; break;
            case 2: rankString = "2ND"; break;
            case 3: rankString = "3RD"; break;
        }

        entryTransform.Find("TimeText").GetComponent<TMP_Text>().text = scoreEntry.time.ToString();
        entryTransform.Find("DeathText").GetComponent<TMP_Text>().text = scoreEntry.death.ToString();
        entryTransform.Find("NameText").GetComponent<TMP_Text>().text = scoreEntry.name;
        entryTransform.Find("PosText").GetComponent<TMP_Text>().text = rankString;

        transformList.Add(entryTransform);
    }

    public void AddEntry(string name, float time, int death) {
        ScoreEntry scoreEntry = new ScoreEntry{name = name, time = time, death = death};
        
        string jsonString = PlayerPrefs.GetString("scoreTable");
        Scores scores = JsonUtility.FromJson<Scores>(jsonString);
        
        scores.scoreEntryList.Add(scoreEntry);
        
        string json = JsonUtility.ToJson(scores);
        PlayerPrefs.SetString("scoreTable", json);
        PlayerPrefs.Save();
    }

    public void DefaultScoreTable() {
        List<ScoreEntry> deafultEntryList = new List<ScoreEntry>();
        Scores scores = new Scores {scoreEntryList = deafultEntryList};
        string json = JsonUtility.ToJson(scores);
        PlayerPrefs.SetString("scoreTable", json);
        PlayerPrefs.Save();
    }

    private class Scores {
        public List<ScoreEntry> scoreEntryList;
        
    }

    [System.Serializable]
    private class ScoreEntry {
        public float time;
        public string name;
        public int death;
    }



}
