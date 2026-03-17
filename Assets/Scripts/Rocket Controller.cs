using UnityEngine;
using UnityEngine.InputSystem;

public class RocketController : MonoBehaviour
{
    public float upwardSpeed = 6f;
    public float horizontalSpeed = 8f;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float moveX = 0f;

        if (Keyboard.current.aKey.isPressed || Keyboard.current.leftArrowKey.isPressed)
        {
            moveX = -horizontalSpeed;
        }

        if (Keyboard.current.dKey.isPressed || Keyboard.current.rightArrowKey.isPressed)
        {
            moveX = horizontalSpeed;
        }

        rb.linearVelocity = new Vector3(moveX, upwardSpeed, 0);
    }
}