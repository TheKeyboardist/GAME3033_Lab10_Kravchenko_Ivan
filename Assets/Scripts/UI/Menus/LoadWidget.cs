using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity;
using UnityEditor;
using UnityEngine.SceneManagement;
using TMPro;

public class LoadWidget : MenuWidget
{
    private GameDataList GameData;


    [SerializeField] private TMP_InputField NewGameInputField;

    [SerializeField] private string SceneToLoad;

    [SerializeField] private RectTransform LoadItemsPanel;

  

    //[SerializeField] public TMP_Inputfield NewGameInputField;

    [SerializeField] private GameObject SaveSlotPrefab;
    private const string SaveFileKey = "FileSaveData";

    [SerializeField] private bool Debug;
    // Start is called before the first frame update
    void Start()
    {
        if (Debug) SaveDebugData();
        WipeChildren();

        LoadGameData();
    }

    private void WipeChildren()
    {

        foreach (RectTransform saveSlot in LoadItemsPanel)
        {
            Destroy(saveSlot.gameObject);
        }
        LoadItemsPanel.DetachChildren();
    }

    private void SaveDebugData()
    {
        GameDataList dataList = new GameDataList();
        dataList.SaveFileNames.AddRange(new List<string> { "Save1", "Save2", "Save3" });
        PlayerPrefs.SetString(SaveFileKey, JsonUtility.ToJson(dataList));
    }
    
    private  void LoadGameData()
    {
        if (!PlayerPrefs.HasKey(SaveFileKey)) return;

        string jsonString = PlayerPrefs.GetString(SaveFileKey);

        GameData = JsonUtility.FromJson<GameDataList>(jsonString);
        if (GameData.SaveFileNames.Count <= 0) return;
        //  UnityEngine.Debug.Log(GameData.SaveFileNames);
        foreach (string saveName in GameData.SaveFileNames)
        {
            SaveSlotWidget widget = Instantiate(SaveSlotPrefab, LoadItemsPanel).GetComponent<SaveSlotWidget>();
            widget.Intialize(this, saveName);
        
        }
    }

    public void LoadScene()
    {
        UnityEngine.Debug.Log("GOingTO Open");
        SceneManager.LoadScene(SceneToLoad);
    }

    public void CreateNewGame()
    {
        if (string.IsNullOrEmpty(NewGameInputField.text))
        {
            //Debug.Log("Error");
            return; 
        }
        GameManager.Instance.SetActiveSave(NewGameInputField.text);
        LoadScene();
    }

    [Serializable]
    class GameDataList
    {
        public List<string> SaveFileNames = new List<string>();
    }
}
