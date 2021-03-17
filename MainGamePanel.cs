using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainGamePanel : MonoBehaviour
{
    [Header("Display Contents")]
    public Text DisplayName;
    public Text DisplayMoney;
    public Text DisplayAge;

    public NameManager nameManager;
    public GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager.StatusRandomRange();
    }

    // Update is called once per frame
    void Update()
    {
        DisplayName.text = nameManager.fullName;
        DisplayMoney.text = "$" + gameManager.Money.ToString();
        DisplayAge.text = "Age: " + gameManager.Age.ToString() + " years";
    }

    public void ButtonAgeClicked()
    {
        gameManager.Age += 1;
    }
}
