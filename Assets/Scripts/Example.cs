using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Example : MonoBehaviour
{
    //Tao list chua option cua dropdown
    private List<string> dropdownOptions = new List<string> { "Option 1", "Option 2", "Option 3" };
    public TMP_Dropdown dropdown;
    public Toggle toggle;
    public Slider slider;

    private void Start()
    {
        dropdown.ClearOptions();
        dropdown.AddOptions(dropdownOptions);
    }

    public void OnClikedButton()
    {
        Debug.Log("Button is cliked");
    }

    public void OnValueChangedToggle()
    {
        if (toggle.isOn)
        {
            Debug.Log("True");
        }
        else
        {
            Debug.Log("False");
        }
    }

    public void OnValueChangedSlider()
    {
        Debug.Log(slider.value);
    }

    public void OnValueChangedDropdown(int value)
    {
        Debug.Log(value);
        switch (value)
        {
            case 0:
                break;
            case 1:
                break;
            case 2:
                break;
        }
    }
    
}
