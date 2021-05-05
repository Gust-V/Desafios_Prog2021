using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Collectable_resource : MonoBehaviour
{
    public string Nameresource { get; protected set; }
    public enum CollectableType { Madeira = 1, Pedra, Grama, Terreno }
    public CollectableType collectableType;

    public int clicks = 0;

    public virtual void OnMouseDown()
    {
        throw new System.NotImplementedException();
    }

    public virtual void Collected()
    {
        throw new System.NotImplementedException();
    }

    public virtual void OnTriggerEnter2D(Collider2D collision)
    {
        throw new System.NotImplementedException();
    }

    public virtual void OnTriggerExit2D(Collider2D collision)
    {
        throw new System.NotImplementedException();
    }
}
