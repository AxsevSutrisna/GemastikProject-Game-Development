using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingPlat : MonoBehaviour
{
    [SerializeField] private GameObject[] point;
    private int currentPointIndex = 0;

    [SerializeField] private float speed = 2f;

    void Update()
    {
        if(Vector2.Distance(point[currentPointIndex].transform.position, transform.position) < .1f)
        {
            currentPointIndex++;
            if (currentPointIndex >= point.Length)
            {
                currentPointIndex = 0;
            }
        }
        transform.position = Vector2.MoveTowards(transform.position, point[currentPointIndex].transform.position, Time.deltaTime * speed);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "Player")
        {
            collision.gameObject.transform.SetParent(transform);
        }

    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            collision.gameObject.transform.SetParent(null);
        }
    }
}
