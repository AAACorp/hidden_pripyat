using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class win : MonoBehaviour {

    public List<Item> items;

    void FindItems()
    {
        items = FindObjectsOfType<Item>().ToList();
    }

    void CheckActive()
    {
        if (items.Count == 0)
        {
            Application.LoadLevel(2);
        }
    }

    private void Awake()
    {
        FindItems();
    }


    void Update ()
    {
        FindItems();
        CheckActive();
    }
}
