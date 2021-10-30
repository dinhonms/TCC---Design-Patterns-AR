using System.Collections;
using UnityEngine;

namespace Assets.TCC.Scripts.Architecture.AbstractyFactory
{
    /// <summary>
    /// Concrete Product
    /// </summary>
    public class Furniture : IInteractableFactory
    {
        public IInteractable GetInteractable()
        {
            return new Chair();
        }
    }
}