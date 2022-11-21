using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinSetter : MonoBehaviour
{
    public FloatVariable pinValue1;
    public FloatVariable pinValue2;
    public FloatVariable pinValue3;

    [SerializeField]
    private GameEvent updatePins;

    public void OnToolClick(GameEvent e) {
        if (e is ToolUsedEvent)
        {
            var toolEvent = (e as ToolUsedEvent);
            pinValue1.Value = pinValue1.Value + toolEvent.pinIncrement1.Value;
            pinValue2.Value = pinValue2.Value + toolEvent.pinIncrement2.Value;
            pinValue3.Value = pinValue3.Value + toolEvent.pinIncrement3.Value;

            updatePins.Raise();
        }
    }
}
