using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference Listener of type `string`. Inherits from `AtomEventReferenceListener&lt;string, StringAction, StringEvent, StringEventReference, StringUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Event Reference Listeners/String Event Reference Listener")]
    public sealed class StringEventReferenceListener : AtomEventReferenceListener<
        string,
        StringAction,
        StringEvent,
        StringEventReference,
        StringUnityEvent>
    { }
}
