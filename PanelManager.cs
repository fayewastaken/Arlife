using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelManager : MonoBehaviour
{
    [Header("Panel")]
    public GameObject MainMenu;
    public GameObject MakingLife;
    public GameObject ChangeName;
    public GameObject ChangeGender;

    public void OpenMakingLifeUI()
    {
        MakingLife.SetActive(true);
    }

    public void CloseMakingLifeUI()
    {
        MakingLife.SetActive(false);
    }

    public void OpenChangeNameUI()
    {
        ChangeName.SetActive(true);
        MakingLife.SetActive(false);

        MakingLife.GetComponent<MakingLifePanel>().UpdateName();
    }

    public void CloseChangeNameUI()
    {
        MakingLife.SetActive(true);
        ChangeName.SetActive(false);

        MakingLife.GetComponent<MakingLifePanel>().UpdateName();
    }

    public void CloseChangeNameUIUnsave()
    {
        MakingLife.SetActive(true);
        ChangeName.SetActive(false);
    }

    public void OpenChangeGenderUI()
    {
        ChangeGender.SetActive(true);
        MakingLife.SetActive(false);
    }

    public void CloseChangeGenderUI()
    {
        MakingLife.SetActive(true);
        ChangeGender.SetActive(false);

        MakingLife.GetComponent<MakingLifePanel>().UpdateGender();
        MakingLife.GetComponent<MakingLifePanel>().UpdateName();
    }

    public void ClearScreen()
    {
        MainMenu.SetActive(false);
        MakingLife.SetActive(false);
        ChangeName.SetActive(false);
        ChangeGender.SetActive(false);
    }

    public void CloseMainMenuUI()
    {
        ClearScreen();

        MakingLife.GetComponent<MakingLifePanel>().UpdateGender();
        MakingLife.GetComponent<MakingLifePanel>().UpdateName();
    }
}
