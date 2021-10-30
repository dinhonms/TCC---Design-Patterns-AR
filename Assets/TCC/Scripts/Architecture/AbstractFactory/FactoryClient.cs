using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.TCC.Scripts.Architecture.AbstractyFactory
{
    public class FactoryClient : MonoBehaviour
    {
        [SerializeField] GameObject[] interactables;

      private  IInteractableFactory interactableFactory;
        private Dictionary<IInteractable, GameObject> interactablesDictionary = new Dictionary<IInteractable, GameObject>();

        void Start()
        {
            foreach (var interactable in interactables)
            {
                interactablesDictionary.Add(interactable.GetComponent<IInteractable>(), interactable);

                Debug.Log($"Interactable prefab {interactable.name} added to dictionary");
            }

            SpawnInteractable(InteractableType.FURNITURE);
        }

        public void SpawnInteractable(InteractableType enemyType)
        {
            switch (enemyType)
            {
                case InteractableType.KITCHEN:
                    interactableFactory = new Kitchen();
                    break;
                case InteractableType.FURNITURE:
                    interactableFactory = new Furniture();
                    break;
                default:
                    break;
            }

            foreach (var item in interactablesDictionary)
            {
                Debug.Log($"Found: {interactableFactory.GetInteractable() == item.Key}");
            }

            interactableFactory.GetInteractable().IsInteractable();
            GameObject currentInteractable = null;
            interactablesDictionary.TryGetValue(interactableFactory.GetInteractable(), out currentInteractable);
            Instantiate(currentInteractable);
        }

    }
}