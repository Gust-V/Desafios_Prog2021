using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ore : Collectable_resource
{
    private bool CollectableSet = false;

    public Player MyPlayer;
    public void Awake()
    {
        Nameresource = "Pedra";
        collectableType = CollectableType.Pedra;
    }

    public override void OnMouseDown()
    {
        if (CollectableSet == true)
        {
            clicks++;
            Collected();
        }
    }

    public override void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Tool_Picareta"))
        {
            CollectableSet = true;
        }
    }

    public override void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Tool_Picaretada"))
        {
            CollectableSet = false;
        }
    }

    public override void Collected()
    {
        if (clicks == 4 && CollectableSet == true)
        {
            MyPlayer.QuantPedra++;
            Destroy(this.gameObject);
        }
    }
}
