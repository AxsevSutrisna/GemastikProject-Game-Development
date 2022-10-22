using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Sign : MonoBehaviour
{

    public GameObject UI;
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
        if(Input.GetKeyDown(KeyCode.F) && playerInRange)
        {
            Time.timeScale = 0;
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
        }
    }
    
    public void ResumeGame()
    {
        Time.timeScale = 1;
        UI.SetActive(false);
    }
}
