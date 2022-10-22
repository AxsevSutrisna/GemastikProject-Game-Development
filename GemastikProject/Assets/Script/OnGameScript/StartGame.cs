using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject UIprov;


    private void Awake()
    {
        Time.timeScale = 0;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Resume()
    {
        Time.timeScale = 1;
        UIprov.SetActive(false);
    }
}
