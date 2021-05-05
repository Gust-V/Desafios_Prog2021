using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gram : Collectable_resource
{
    private bool CollectableSet = false;

    public Player MyPlayer;
    public void Awake()
    {
        Nameresource = "Grama";
        collectableType = CollectableType.Grama;
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
        if (collision.gameObject.name.Equals("Tool_Foice"))
        {
            CollectableSet = true;
        }
    }

    public override void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Tool_Foice"))
        {
            CollectableSet = false;
        }
    }

    public override void Collected()
    {
        if (clicks == 1 && CollectableSet == true)
        {
            MyPlayer.QuantGrama++;
            Destroy(this.gameObject);
        }
    }
}
