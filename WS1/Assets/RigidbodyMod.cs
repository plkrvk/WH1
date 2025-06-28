using UnityEngine;
using UnityEngine.InputSystem; // Новый Input System

public class RigidbodyMod : MonoBehaviour
{
    private Rigidbody _rb;

    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            Debug.Log("Базовые настройки");
            _rb.mass = 1.0f;
            _rb.linearDamping = 0f;
            _rb.angularDamping = 0.05f;
            _rb.useGravity = true;
        }

        if (Keyboard.current.fKey.wasPressedThisFrame)
        {
            Debug.Log("Взлёт");
            _rb.AddForce(Vector3.up * 500f);
        }

        if (Keyboard.current.rKey.wasPressedThisFrame)
        {
            Debug.Log("Сброс");
            _rb.mass = 1.0f;
            _rb.linearDamping = 0f;
            _rb.angularDamping = 0.05f;
            _rb.useGravity = true;
            _rb.linearVelocity = Vector3.zero;
            _rb.angularVelocity = Vector3.zero;
        }

        if (Keyboard.current.tKey.wasPressedThisFrame)
        {
            Debug.Log("Невесомость");
            _rb.useGravity = false;
            _rb.mass = 0.01f;
        }
    }
}
