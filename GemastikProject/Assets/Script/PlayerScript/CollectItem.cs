using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectItem : MonoBehaviour
{
    public List<string> inventory;
    void Start()
    {
        inventory = new List<string>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        string itemType = collision.gameObject.GetComponent<CollectableScript>().itemType;

        inventory.Add(itemType);
        Destroy(collision.gameObject);
    }

}
