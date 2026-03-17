using UnityEngine;

public class AsteroidSpawner : MonoBehaviour
{
    public GameObject asteroidPrefab;
    public Transform rocket;

    public float spawnDistance = 15f;
    public float spawnWidth = 10f;
    public float spawnRate = 1.2f;

    void Start()
    {
        InvokeRepeating(nameof(SpawnAsteroid), 1f, spawnRate);
    }

    void SpawnAsteroid()
    {
        float randomX = Random.Range(-spawnWidth, spawnWidth);

        Vector3 spawnPos = new Vector3(
            randomX,
            rocket.position.y + spawnDistance,
            0
        );

        Instantiate(asteroidPrefab, spawnPos, Quaternion.identity);
    }
}