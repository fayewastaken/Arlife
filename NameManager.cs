using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NameManager : MonoBehaviour
{
    public string fullName;
    public string firstName;
    public string lastName;
    public string gender;

    public static string MALE = "Male";
    public static string FEMALE = "Female";

    public NameVar GenerateName()
    {
        NameVar nameVar = new NameVar();

        float rndGender = Mathf.Round(Random.Range(0f, 100f));
        if (rndGender > 50) {
            nameVar.gender = MALE;
            nameVar.name = NVJOBNameGen.GiveAName(4);
        } else {
            nameVar.gender = FEMALE;
            nameVar.name = NVJOBNameGen.GiveAName(2);
        }

        gender = nameVar.gender;
        fullName = nameVar.name;

        string[] arName = fullName.Split(' ');
        firstName = arName[0];
        lastName = arName[1];

        return nameVar;
    }

    public void ChangeName(string newName)
    {
        fullName = newName;

        string[] arName = fullName.Split(' ');
        firstName = arName[0];
        lastName = arName[1];
    }

    public string GetFullName()
    {
        return fullName;
    }

    public string GetFirstName()
    {
        return firstName;
    }

    public string GetLastName()
    {
        return lastName;
    }

    [System.Serializable]
    public struct NameVar
    {
        public string gender;
        public string name;
    }
}
