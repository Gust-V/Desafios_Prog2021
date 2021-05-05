using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Axe : Tool
{
    protected override void Awake()
    {
        ItemName = "Machado de Ferro";
        DescriptionItem = "Ferramenta utilizada para cortar madeira";
        toolType = ToolType.Machado;
        base.Awake();
        ToolTP();
    }
}
