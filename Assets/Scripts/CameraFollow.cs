using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform rocket;
    public float offsetY = 4f;

    void LateUpdate()
    {
        Vector3 newPosition = transform.position;
        newPosition.y = rocket.position.y + offsetY;
        transform.position = newPosition;
    }
}