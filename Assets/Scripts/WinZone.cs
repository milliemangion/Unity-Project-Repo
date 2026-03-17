using UnityEngine;

public class WinZone : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("YOU WIN!");
            Time.timeScale = 0f;
        }
    }
}