﻿
    public class Product
    {
    public string Name { get; set; }
    public int Price { get; set; }

    public Product(string name, int price)
    {
        Name = name;
        Price = price;
    }

    public virtual string ToString()
    {
        return "Giving you: " + Name;
    }

    }

