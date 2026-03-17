using UnityEngine;

public class StarSpawner : MonoBehaviour
{
    public GameObject starPrefab;
    public Transform rocket;

    public float spawnDistance = 15f;
    public float spawnWidth = 7f;
    public float spawnRate = 2f;

    void Start()
    {
        InvokeRepeating(nameof(SpawnStar), 2f, spawnRate);
    }

    void SpawnStar()
    {
        float randomX = Random.Range(-spawnWidth, spawnWidth);

        Vector3 spawnPosition = new Vector3(
            randomX,
            rocket.position.y + spawnDistance,
            0
        );

        Instantiate(starPrefab, spawnPosition, Quaternion.identity);
    }
}