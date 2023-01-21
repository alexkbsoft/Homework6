using UnityEngine;
using UnityEngine.Events;

public class ListenerOfImpactChannel : MonoBehaviour
{
    public UnityEvent<Impact> OnEventRaised;

    [SerializeField]
    private ImpactChannel channel;
    

    private void OnEnable()
    {
        if (channel != null)
            channel.OnImpact += Respond;
    }

    private void OnDisable()
    {
        if (channel != null)
            channel.OnImpact -= Respond;
    }

    private void Respond(Impact value) {
        if (OnEventRaised != null)
        {
            OnEventRaised.Invoke(value);
        }
    }
}