using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading;
using UnityEngine;

public class ShopScript : MonoBehaviour
{
    public Dictionary<string, Item> Items = new()
    {
        ["TrafficLight"] = new Item(new(0, 0), 10, "TrafficLight", this)
    }d
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

public class Item
{
    public Vector2 relativePos;
    public int Price;
    public string Name;
    public ShopScript ss;
    public Item(Vector2 relativePos, int Price, string Name, ShopScript ss)
    {
        this.relativePos = relativePos;
        this.Price = Price;
        this.ss = ss;
        this.Name = Name;
    }

    public bool Buy()
    {
        if (!(ss.Funds - Price >= 0)) return false;
        ss.Funds -= Price;
        return true;
    }
}