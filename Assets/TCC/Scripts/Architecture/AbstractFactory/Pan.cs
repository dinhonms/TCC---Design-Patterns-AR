using System.Collections;
using UnityEngine;

namespace Assets.TCC.Scripts.Architecture.AbstractyFactory
{
    /// <summary>
    /// Concrete Product
    /// </summary>
    public class Pan : MonoBehaviour, IInteractable
    {
        [SerializeField] bool isInteractable;

        public bool IsInteractable()
        {
            return this.isInteractable;
        }
    }
}