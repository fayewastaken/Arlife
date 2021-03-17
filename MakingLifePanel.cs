using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MakingLifePanel : MonoBehaviour
{
    [Header("Gender Theme")]
    public GameObject MaleTheme;
    public GameObject FemaleTheme;

    [Header("Button Text")]
    public Text StartLife;
    public Text RandomNameMale;
    public Text RandomNameFemale;

    public NameManager nameManager;
    public PanelManager panelManager;

    void Start()
    {
        ScrambleName();
    }

    void ScrambleName()
    {
        NameManager.NameVar nv = nameManager.GenerateName();

        if (nv.gender == NameManager.MALE) {
            MaleTheme.SetActive(true);
            FemaleTheme.SetActive(false);
        } else {
            FemaleTheme.SetActive(true);
            MaleTheme.SetActive(false);
        }

        UpdateName();
    }

    public void UpdateName()
    {
        if (nameManager.gender == NameManager.MALE) {
            RandomNameMale.text = nameManager.fullName;
        } else {
            RandomNameFemale.text = nameManager.fullName;
        }

        StartLife.text = "Start " + nameManager.firstName + "'s life!";
    }

    public void UpdateGender()
    {
        if (nameManager.gender == NameManager.MALE)
        {
            MaleTheme.SetActive(true);
            FemaleTheme.SetActive(false);
        } else {
            FemaleTheme.SetActive(true);
            MaleTheme.SetActive(false);
        }
    }

    public void OnScrambleNameClicked()
    {
        ScrambleName();
    }

    public void OnStartLifeClicked()
    {
        panelManager.CloseMainMenuUI();
    }

    public void OnChangeNameClicked()
    {
        panelManager.OpenChangeNameUI();
    }

    public void OnChangeGenderClicked()
    {
        panelManager.OpenChangeGenderUI();
    }
}
