using System.Collections;
using UnityEngine;

namespace Assets.TCC.Scripts.Architecture.AbstractyFactory
{
    /// <summary>
    /// Concrete Class
    /// </summary>
    public class Kitchen : IInteractableFactory
    {
        public IInteractable GetInteractable()
        {
            return new Pan();
        }
    }
}