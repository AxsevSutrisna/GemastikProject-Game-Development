using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    private int items, victoryCondition = 3;
    public GameObject UIFinish;
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

    private static GameManager instance;

    public static GameManager MyInstance
    {
         get
        {
            if (instance == null)
                instance = new GameManager();
            return instance;
        }
    }

    private void Start()
    {
        UIManager.MyInstance.UpdateItemUI(items, victoryCondition);
    }

    public void AddItem(int _items)
    {
        items += _items;
        UIManager.MyInstance.UpdateItemUI(items, victoryCondition);
    }

    public void Finish()
    {
        if (items >= victoryCondition)
        {
            UIFinish.SetActive(true);
            Time.timeScale = 0;
        }
        else
        {
            UIManager.MyInstance.ShowVictoryCondition(items, victoryCondition);
        }
    }
}
