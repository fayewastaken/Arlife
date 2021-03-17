using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarManager : MonoBehaviour
{
    public Image HappinessBar;
    public Image HealthBar;
    public Image SmartsBar;
    public Image LooksBar;

    public float CurrentHappiness;
    public float CurrentHealth;
    public float CurrentSmarts;
    public float CurrentLooks;

    private float MaxHappiness = 100f;
    private float MaxHealth = 100f;
    private float MaxSmarts = 100f;
    private float MaxLooks = 100f;

    public GameManager gameManager;

    //private void Start()
    //{
    //    //Find
    //    HappinessBar = GetComponent<Image>();
    //    HealthBar = GetComponent<Image>();
    //    SmartsBar = GetComponent<Image>();
    //    LooksBar = GetComponent<Image>();
    //}

    private void Update()
    {
        CurrentHappiness = gameManager.Happiness;
        CurrentHealth = gameManager.Health;
        CurrentSmarts = gameManager.Smarts;
        CurrentLooks = gameManager.Looks;

        HappinessBar.fillAmount = CurrentHappiness / MaxHappiness;
        HealthBar.fillAmount = CurrentHealth / MaxHealth;
        SmartsBar.fillAmount = CurrentSmarts / MaxSmarts;
        LooksBar.fillAmount = CurrentLooks / MaxLooks;
    }
}
