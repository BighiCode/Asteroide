using UnityEngine;

public class AsteroidSpawn : MonoBehaviour
{
    private void SpawnAsteroid(Asteroid asteroid, Vector3 local)
    {
        var prefab = Resources.Load<GameObject>("Prefabs/Asteroid");
        prefab.GetComponent<Asteroid>().Resistence = asteroid.Resistence; 
        prefab.GetComponent<Asteroid>().Size = asteroid.Size; 
        prefab.GetComponent<Asteroid>().Life = asteroid.Life;
        Instantiate(prefab, local, Quaternion.identity);
    }
}
