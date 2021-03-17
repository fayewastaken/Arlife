using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainGamePanel : MonoBehaviour
{
    [Header("Display Contents")]
    public Text DisplayName;
    public Text DisplayAge;
    public Text DisplayMoney;

    public NameManager nameManager;

    public float Money;
    public float Age;

    // Start is called before the first frame update
    void Start()
    {
        print(DisplayName.text);
    }

    // Update is called once per frame
    void Update()
    {
        DisplayName.text = nameManager.fullName;
        DisplayMoney.text = "$" + Money.ToString();
        DisplayAge.text = Age.ToString();
    }

    public void TestMoney()
    {
        Money += 1000;
    }

    public void ButtonAgeClicked()
    {
        Age += 1;
    }
}
