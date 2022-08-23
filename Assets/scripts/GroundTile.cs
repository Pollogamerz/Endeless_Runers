using UnityEngine;

public class GroundTile : MonoBehaviour
{
    Groundspawner groundSpawner;
    
    void Start()
    {
        groundSpawner = GameObject.FindObjectOfType<Groundspawner>();
        SpawnObstacle();
    }

    private void OnTriggerEnter(Collider other)
    {
        groundSpawner.SpawnTile();
        Destroy(gameObject, 2);
    }

    void Update()
    {
        
    }

    public GameObject obstaclePrefab;

    void SpawnObstacle()
    {
        int obstacleSpawnIndex = Random.Range(2, 5);
        Transform spawpoint = transform.GetChild(obstacleSpawnIndex);
        Instantiate(obstaclePrefab, spawpoint.position, Quaternion.identity, transform);
    }
}
