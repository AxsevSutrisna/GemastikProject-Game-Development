using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelComplete : MonoBehaviour
{

    private void OnTriggerEnter2D (Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            GameManager.MyInstance.Finish();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            UIManager.MyInstance.HideShowVictoryCondition();
        }
    }
}
