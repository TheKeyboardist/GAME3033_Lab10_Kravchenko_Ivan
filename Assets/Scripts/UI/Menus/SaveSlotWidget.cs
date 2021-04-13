using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SaveSlotWidget : MonoBehaviour
{
    private string SaveName;

    private GameManager Manager;
    private LoadWidget LoadWidget;

    [SerializeField] private TMP_Text SaveNameText;


    private void Awake()
    {
        Manager = GameManager.Instance;
        
    }

    public void Intialize(LoadWidget parentWidget, string saveName)
    {
        LoadWidget = parentWidget;
        SaveName = saveName;
        SaveNameText.text = saveName;
    }

    public void SelectSave()
    {
        Manager.SetActiveSave(SaveName);
        UnityEngine.Debug.Log("GOingTO OpenLoad");

        LoadWidget.LoadScene();
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
