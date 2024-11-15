using System;
using UnityEngine;
using UnityEngine.InputSystem;

namespace StencilTestDemo.Scripts
{
    public class StencilHole : MonoBehaviour
    {
        [SerializeField] private float _movementSpeed = 2f;
        [SerializeField] private InputActionReference _movementReference;

        private void Update()
        {
            Vector3 movementInput = _movementReference.action.ReadValue<Vector2>();
            Vector3 movement = new Vector3(movementInput.x, 0f, movementInput.y) * _movementSpeed * Time.deltaTime;
            transform.Translate(movement, Space.World);
        }

        private void OnEnable()
        {
            _movementReference.action.Enable();
        }

        private void OnDisable()
        {
            _movementReference.action.Disable();
        }
    }
}