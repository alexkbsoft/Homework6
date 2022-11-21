using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;

public class Pin : MonoBehaviour
{
    public TextMeshProUGUI pinText;
    public FloatReference currentPinValue;

    private void Start() {
        pinText.text = currentPinValue.Value.ToString();
    }

    public void SetNewValue() {
        if (pinText != null)
        {
            pinText.text = currentPinValue.Value.ToString();
        }
    }
}
