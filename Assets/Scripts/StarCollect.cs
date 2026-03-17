using UnityEngine;

public class StarCollect : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Star Collected");
            Destroy(gameObject);
        }
    }
}