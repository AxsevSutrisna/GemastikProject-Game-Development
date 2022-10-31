using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatingAnimation : MonoBehaviour
{
    public float amp = 0.1f;
    public float freq = 5f;
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
