using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hook : Tool
{
    //Tool MachadoOb = new Tool("Machado de Ferro", "Ferramenta para coletar madeira", Tool.ToolType.Machado);

    protected override void Awake()
    {
        ItemName = "Foice de Ferro";
        DescriptionItem = "Ferramenta utilizada para cortar grama";
        toolType = ToolType.Foice;
        base.Awake();
        ToolTP();
    }
}