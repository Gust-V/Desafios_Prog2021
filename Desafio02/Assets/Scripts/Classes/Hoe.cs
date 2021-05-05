using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hoe : Tool
{
    //Tool MachadoOb = new Tool("Machado de Ferro", "Ferramenta para coletar madeira", Tool.ToolType.Machado);

    protected override void Awake()
    {
        ItemName = "Enxada de Ferro";
        DescriptionItem = "Ferramenta utilizada para capinar um lote";
        toolType = ToolType.Enxada;
        base.Awake();
        ToolTP();
    }
}