using UnityEngine;

namespace StencilTestDemo.Scripts
{
    public class StencilHoleTrigger : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            other.transform.gameObject.layer = LayerMask.NameToLayer("Inside Hole");
        }

        private void OnTriggerExit(Collider other)
        {
            other.transform.gameObject.layer = LayerMask.NameToLayer("Default");
        }
    }
}