using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorChangeMenu : MonoBehaviour
{
    public GameObject colorPanelUI;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            if (!colorPanelUI.activeSelf)
            {
                colorPanelUI.SetActive(true);
            }
            else
            {
                colorPanelUI.SetActive(false);
            }
        }
    }
}
