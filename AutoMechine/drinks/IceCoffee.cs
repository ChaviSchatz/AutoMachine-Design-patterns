﻿
    public class IceCoffee : Product
    {
    public string Description { get; set; } = "";
    public string ToString()
    {
        return base.ToString + Description;
    }
}
