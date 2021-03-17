using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeNamePanel : MonoBehaviour
{
    [Header("ChangeName InputField")]
    public Text FirstNamePlaceholder;
    public Text LastNamePlaceholder;

    public NameManager nameManager;
    public PanelManager panelManager;

    public InputField inputFirstName;
    public InputField inputLastName;

    void Start()
    {
        FirstNamePlaceholder.text = nameManager.firstName;
        LastNamePlaceholder.text = nameManager.lastName;
    }

    public void OnSaveChanges()
    {
        string newName = inputFirstName.text + " " + inputLastName.text;

        nameManager.ChangeName(newName);
        panelManager.CloseChangeNameUI();
    }

    public void OnBackClicked()
    {
        panelManager.CloseChangeNameUI();
        inputFirstName.clear();
        inputLastName.clear();
    }
}

public static class Extension
{
    public static void clear(this InputField inputfield)
    {
        inputfield.Select();
        inputfield.text = "";
    }
}