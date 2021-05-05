using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pick : Tool
{
    //Tool MachadoOb = new Tool("Machado de Ferro", "Ferramenta para coletar madeira", Tool.ToolType.Machado);

    protected override void Awake()
    {
        ItemName = "Picareta de Ferro";
        DescriptionItem = "Ferramenta utilizada para quebrar pedra";
        toolType = ToolType.Picartea;
        base.Awake();
        ToolTP();
    }
}