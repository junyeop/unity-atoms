using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference Listener of type `Vector3`. Inherits from `AtomEventReferenceListener&lt;Vector3, Vector3Action, Vector3Event, Vector3EventReference, Vector3UnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Event Reference Listeners/Vector3 Event Reference Listener")]
    public sealed class Vector3EventReferenceListener : AtomEventReferenceListener<
        Vector3,
        Vector3Action,
        Vector3Event,
        Vector3EventReference,
        Vector3UnityEvent>
    { }
}
