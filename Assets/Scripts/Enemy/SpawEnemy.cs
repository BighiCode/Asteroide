using CorposCelestes.Asteroides;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawEnemy : MonoBehaviour
{
    public int AsteroidSpawnDelay;
    public float clock;

    private void Update()
    {
        clock += Time.deltaTime;
        if (clock <= AsteroidSpawnDelay) return;
        SpawnAsteroid(transform.localPosition);
        clock = 0;
    }

    private static void SpawnAsteroid(Vector3 local)
    {
        var prefab = Resources.Load<GameObject>("Prefabs/Enemy");
        Instantiate(prefab, local, Quaternion.identity);
    }
}
