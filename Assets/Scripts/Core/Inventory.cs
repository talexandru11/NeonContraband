using System;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    private Dictionary<ProductData, int> products = new();

    public int GetAmount(ProductData product)
    {
        if (products.ContainsKey(product))
        {
            return products[product];
        }

        return 0;
    }

    public void AddProduct(ProductData product, int amount)
    {
        if (!products.ContainsKey(product))
        {
            products[product] = 0;
        }
        products[product] += amount;
    }
    
    public bool RemoveProduct(ProductData product, int amount)
    {
        if(GetAmount(product) < amount)
        {
            return false;
        }

        products[product] -= amount;

        return true;
    }
}
