using System.Collections;
using UnityEngine;

namespace Assets.TCC.Scripts.Architecture.AbstractyFactory
{
    /// <summary>
    /// Concrete Product
    /// </summary>
    public class Plate : MonoBehaviour, IInteractable
    {
        [SerializeField] bool isActive;

        public bool IsInteractable()
        {
            return this.isActive;
        }
    }
}