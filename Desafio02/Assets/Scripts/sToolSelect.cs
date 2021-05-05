using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sToolSelect : MonoBehaviour
{
    public int aux = 0;
    public int selectedTool = 0;

    // Start is called before the first frame update
    void Start()
    {
        SelectedTool();
    }

    void Update()
    {
        int armaant = selectedTool;

        selectedTool = aux;

        if (armaant != selectedTool)
        {
            SelectedTool();
        }
    }

    void SelectedTool()
    {
        int i = 0;

        foreach (Transform tool in transform)
        {
            if (i == selectedTool)
            {
                tool.gameObject.SetActive(true);
            }
            else
            {
                tool.gameObject.SetActive(false);
            }
            i++;
        }
    }
}
