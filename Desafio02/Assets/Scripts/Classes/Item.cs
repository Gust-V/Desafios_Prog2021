using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public string ItemName { get; protected set; }
    public string DescriptionItem { get; protected set; }
    public float Price { get; protected set; }
    public bool CanSellItem { get; protected set; }


    public void NeedPrice()
    {
        if (CanSellItem == true && Price == 0)
        {
            throw new System.NotImplementedException("Preço do item precisa ser definido");
        }
        else if (CanSellItem == false && Price > 0)
        {
            throw new System.NotImplementedException("Item não pode ser vendido, preço deve ser zero");
        }
        return;
    }
}
