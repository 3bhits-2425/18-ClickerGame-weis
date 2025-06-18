using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject[] fruitPrefabs;
    public GameObject[] bombPrefabs;
    public float spawnInterval = 1f;
    public float xRange = 8f;
    public float yRange = 4f;
    public float zSpawn = 5f;


    void Start()
    {
        InvokeRepeating(nameof(SpawnObject), 1f, spawnInterval);
    }

    void SpawnObject()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-xRange, xRange), Random.Range(-yRange, yRange), zSpawn);
        GameObject prefabToSpawn;

        if (Random.value < 0.2f) // 20% Wahrscheinlichkeit für Bombe
            prefabToSpawn = bombPrefabs[Random.Range(0, bombPrefabs.Length)];
        else
            prefabToSpawn = fruitPrefabs[Random.Range(0, fruitPrefabs.Length)];

        GameObject obj = Instantiate(prefabToSpawn, spawnPos, Quaternion.identity);
        Rigidbody2D rb = obj.GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            rb.velocity = new Vector3(Random.Range(-1f, 1f), Random.Range(5f, 10f), Random.Range(5f, 0f));
        }
    }
}
