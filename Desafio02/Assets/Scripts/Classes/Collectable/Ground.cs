using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : Collectable_resource
{
    private bool CollectableSet = false;
    public bool CanPlant { get; protected set; }

    private SpriteRenderer sprite;
    public Sprite PlantSprite;

    public void Awake()
    {
        sprite = this.gameObject.GetComponent<SpriteRenderer>();
        Nameresource = "Terreno";
        collectableType = CollectableType.Terreno;
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
        if (collision.gameObject.name.Equals("Tool_Enxada"))
        {
            CollectableSet = true;
        }
    }

    public override void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Tool_Enxada"))
        {
            CollectableSet = false;
        }
    }

    public override void Collected()
    {
        if (clicks == 1 && CollectableSet == true)
        {
            CanPlant = true;
            sprite.sprite = PlantSprite;
        }
    }
}
