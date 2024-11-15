using System;
using UnityEngine;

namespace StencilTestDemo.Scripts
{
    public class StencilHoleTrigger : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            other.transform.gameObject.layer = LayerMask.NameToLayer("Inside Hole");
            Rigidbody rb = other.transform.GetComponent<Rigidbody>();
            rb.velocity = Vector3.zero;
            rb.position += Vector3.one * 0.00001f;
        }

        private void OnTriggerStay(Collider other)
        {
            other.transform.gameObject.layer = LayerMask.NameToLayer("Inside Hole");
            Rigidbody rb = other.transform.GetComponent<Rigidbody>();
            rb.WakeUp();
        }

        private void OnTriggerExit(Collider other)
        {
            other.transform.gameObject.layer = LayerMask.NameToLayer("Default");
            Rigidbody rb = other.transform.GetComponent<Rigidbody>();
            rb.velocity = Vector3.zero;
            rb.position += Vector3.one * 0.00001f;
        }
    }
}