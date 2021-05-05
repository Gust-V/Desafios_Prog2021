using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tool : Item
{
    private enum CollectableType {Madeira = 1, Pedra, Grama, Terreno }
    public enum ToolType {Machado = 1, Picartea, Foice, Enxada }

    private CollectableType collectableType;
    public ToolType toolType;

    private bool CantSell = false;

    protected virtual void Awake()
    {
        CanSellItem = CantSell;
        NeedPrice();
    }

    public void ToolTP()
    {
        if (toolType == ToolType.Machado)
        {
            Debug.Log("É um Machado");
            collectableType = CollectableType.Madeira;
            Debug.Log(collectableType);
        }
        else if (toolType == ToolType.Foice)
        {
            Debug.Log("É uma Foice");
            collectableType = CollectableType.Grama;
            Debug.Log(collectableType);
        }
        else if (toolType == ToolType.Picartea)
        {
            Debug.Log("É uma Picareta");
            collectableType = CollectableType.Pedra;
            Debug.Log(collectableType);
        }
        else if (toolType == ToolType.Enxada)
        {
            Debug.Log("É uma Enxada");
            collectableType = CollectableType.Terreno;
            Debug.Log(collectableType);
        }
    }
}
