using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI txtItem, txtVictoryCondition;
    [SerializeField] GameObject victoryCondition;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            DestroyImmediate(this);
        }
    }

    private static UIManager instance;

    public static UIManager MyInstance
    {
        get
        {
            if (instance == null)
                instance = new UIManager();
            return instance;
        }
    }

    public void UpdateItemUI(int _items, int _victoryCondition)
    {
        txtItem.text = "ITEM TERKUMPUL : " + _items + " / " + _victoryCondition;

    }
    public void ShowVictoryCondition(int _items, int _victoryCondition)
    {
        victoryCondition.SetActive(true);
        txtVictoryCondition.text = "Masih kurang " + (_victoryCondition - _items) + " Item";      
    }
    public void HideShowVictoryCondition()
    {
        victoryCondition.SetActive(false);
    }
}
