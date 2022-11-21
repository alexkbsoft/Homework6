using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class ResponseEvent : UnityEvent<GameEvent>
{
}

public class GameEventListener : MonoBehaviour
{
    [Tooltip("Event to register with.")]
    public GameEvent Event;

    [Tooltip("Response to invoke when Event is raised.")]
    public ResponseEvent Response;

    private void OnEnable()
    {
        Event.RegisterListener(this);
    }

    private void OnDisable()
    {
        Event.UnregisterListener(this);
    }

    public void OnEventRaised()
    {
        Debug.Log("OnEventRaised");
        Response.Invoke(Event);
    }
}
