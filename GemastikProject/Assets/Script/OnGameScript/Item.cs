using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : Collectable
{
    [SerializeField] int itemValue = 1;

    protected override void Collected()
    {
        GameManager.MyInstance.AddItem(itemValue);
        Destroy(this.gameObject);
    }
}
