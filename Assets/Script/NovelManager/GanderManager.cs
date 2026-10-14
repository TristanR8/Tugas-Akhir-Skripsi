using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GanderManager : MonoBehaviour
{
    public Dropdown genderDropdown;

    public void SimpanGender()
    {
        int gender = genderDropdown.value;

        PlayerPrefs.SetInt("Gender", gender);
        PlayerPrefs.Save();
    }
}
