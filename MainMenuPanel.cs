using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuPanel : MonoBehaviour
{

    public PanelManager panelManager;

    public void OnStartClicked()
    {
        panelManager.OpenMakingLifeUI();
    }

    public void OnQuitClicked()
    {
        Application.Quit();
    }
}
