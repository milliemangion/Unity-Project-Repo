using UnityEngine;

public class AsteroidMovement : MonoBehaviour
{
    public float speed = 8f;

    void Update()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);
    }
}