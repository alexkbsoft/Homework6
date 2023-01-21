using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;

[System.Serializable]
public struct Impact {
    public int pin1;
    public int pin2;
    public int pin3;
}

public class Pin : MonoBehaviour
{
    public TextMeshProUGUI pinText;
    [SerializeField]
    private int currentValue = 0;

    private void Start() {
        pinText.text = currentValue.ToString();
    }

    public int CurrentValue {
        get => currentValue;
        set {
            currentValue = value;
            pinText.text = currentValue.ToString();
        }
    }

    public void IncrementValue(int increment) {
        currentValue += increment;
        pinText.text = currentValue.ToString();
    }

    public bool IsValid(int increment) {
        var newVal = currentValue + increment;
        
        return newVal <= 10 && newVal >= 0;
    }
}
