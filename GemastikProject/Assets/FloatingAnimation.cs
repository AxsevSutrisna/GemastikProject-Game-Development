using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatingAnimation : MonoBehaviour
{
    public float amp;
    public float freq;
    Vector3 initPos;

    private void Start()
    {
        initPos = transform.position;
    }

    void Update()
    {
        transform.position = new Vector3(initPos.x, Mathf.Sin(Time.time*freq)*amp+initPos.y, 0);
    }
}
