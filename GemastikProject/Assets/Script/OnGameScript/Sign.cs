using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Sign : MonoBehaviour
{

    public GameObject UI;
    public GameObject Panel;

    public bool playerInRange; 
    // Start is called before the first frame update

    private void Awake()
    {
        Time.timeScale = 1;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(playerInRange)
        {
            UI.SetActive(true);
        }
    }

    private void OnTriggerEnter2D (Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = true;
        }
    }

    private void OnTriggerExit2D (Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = false;
            UI.SetActive(false);
        }
    }

    public void PanelUI()
    {
        Time.timeScale = 0;
        Panel.SetActive(true);
    }
    
    public void ResumeGame()
    {
        Time.timeScale = 1;
        Panel.SetActive(false);
    }
}
