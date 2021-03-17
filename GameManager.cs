using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float Money;
    public float Age;

    public float Happiness;
    public float Health;
    public float Smarts;
    public float Looks;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) {
            Application.Quit();
        }
    }

    public void StatusRandomRange()
    {
        Happiness = Mathf.Round(Random.Range(40f, 100f));
        Health = Mathf.Round(Random.Range(60f, 100f));
        Smarts = Mathf.Round(Random.Range(60f, 100f));
        Looks = Mathf.Round(Random.Range(0f, 100f));
    }
}
