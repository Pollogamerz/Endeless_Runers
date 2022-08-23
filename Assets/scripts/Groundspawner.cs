using UnityEngine;

public class Groundspawner: MonoBehaviour
{
    public GameObject groundTile;
    Vector3 nextSpawnPoint;

    public void SpawnTile()
    {
        GameObject temp = Instantiate(groundTile, nextSpawnPoint, Quaternion.identity);
        nextSpawnPoint = temp.transform.GetChild(2).transform.position;
    }

    void Start()
    {
        for (int i = 0; i < 15; i++)
        {
            SpawnTile();
        }
    }

}
