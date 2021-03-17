using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeGenderPanel : MonoBehaviour
{
    public NameManager nameManager;
    public PanelManager panelManager;

    public void OnMaleClicked()
    {
        nameManager.gender = NameManager.MALE;
        panelManager.CloseChangeGenderUI();
    }

    public void OnFemaleClicked()
    {
        nameManager.gender = NameManager.FEMALE;
        panelManager.CloseChangeGenderUI();
    }
}
