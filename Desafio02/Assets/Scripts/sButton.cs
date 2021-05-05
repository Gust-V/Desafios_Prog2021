using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class sButton : MonoBehaviour
{
    public sToolSelect sToolSelect;
    public GameObject aux;

    public void Pull()
    {
        string nameButton = EventSystem.current.currentSelectedGameObject.name;

        if (nameButton == "B_Machado")
        {
            sToolSelect.aux = 0;
        }
        else if (nameButton == "B_Foice")
        {
            sToolSelect.aux = 1;
        }
        else if (nameButton == "B_Picareta")
        {
            sToolSelect.aux = 2;
        }
        else if (nameButton == "B_Enxada")
        {
            sToolSelect.aux = 3;
        }
        else if (nameButton == "Button")
        {
            Destroy(aux);
        }


    }
}
