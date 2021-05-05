using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree : Collectable_resource
{
    private bool CollectableSet = false;

    public Player MyPlayer;
    public void Awake()
    {
        Nameresource = "Madeira";
        collectableType = CollectableType.Madeira;
    }

    public override void OnMouseDown()
    {
        if(CollectableSet == true)
        {
            clicks++;
            Collected();
        }
    }

    public override void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Tool_Machado"))
        {
            CollectableSet = true;
        }
    }

    public override void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Tool_Machado"))
        {
            CollectableSet = false;
        }
    }

    public override void Collected()
    {
        if(clicks == 3 && CollectableSet == true)
        {
            MyPlayer.QuantMadeira++;
            Destroy(this.gameObject);
        }
    }
}
