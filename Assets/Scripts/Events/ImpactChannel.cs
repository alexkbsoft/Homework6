using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(menuName = "Create impact channel")]
public class ImpactChannel : ScriptableObject {
    public UnityAction<Impact> OnImpact;

    public void RaiseEvent(Impact impactVals) {
        if (OnImpact != null)
        {
            OnImpact.Invoke(impactVals);
        }
    }
}