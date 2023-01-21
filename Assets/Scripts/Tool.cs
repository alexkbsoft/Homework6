using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Tool : MonoBehaviour
{
    public Impact impact;
    public ImpactChannel channel;
    public TextMeshProUGUI pinText;
    public TextMeshProUGUI nameText;
    public string toolName;

    void Start()
    {
        pinText.text = $"{impact.pin1} {impact.pin2} {impact.pin3}";
        nameText.text = toolName;
    }

    public void Press() {
        if (channel)
        {
            channel.RaiseEvent(impact);
        }
    }

 
}
