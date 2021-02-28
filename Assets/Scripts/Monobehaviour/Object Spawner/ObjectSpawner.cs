using UnityEngine;

public class ObjectSpawner : MonoBehaviour, IObjectSpawner
{
    public void SpawnObject(GameObject objectForSpawn)
    {
        Instantiate(objectForSpawn, transform.position, objectForSpawn.transform.rotation);
    }
}

public interface IObjectSpawner
{
    void SpawnObject(GameObject objectForSpawn);
}
