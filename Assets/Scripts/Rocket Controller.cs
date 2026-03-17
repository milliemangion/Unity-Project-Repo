using UnityEngine;
using UnityEngine.InputSystem;

public class RocketController : MonoBehaviour
{
    public float upwardSpeed = 0.5f;
    public float horizontalSpeed = 8f;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        // Constant upward movement
        rb.AddForce(Vector3.up * upwardSpeed, ForceMode.Acceleration);

        // Move left
        if (Keyboard.current.aKey.isPressed || Keyboard.current.leftArrowKey.isPressed)
        {
            rb.AddForce(Vector3.left * horizontalSpeed, ForceMode.Acceleration);
        }

        // Move right
        if (Keyboard.current.dKey.isPressed || Keyboard.current.rightArrowKey.isPressed)
        {
            rb.AddForce(Vector3.right * horizontalSpeed, ForceMode.Acceleration);
        }
    }
}