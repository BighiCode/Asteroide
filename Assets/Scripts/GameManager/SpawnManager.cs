using CorposCelestes.Asteroides;
using UnityEngine;
using UnityEngine.SocialPlatforms;

namespace GameManager
{
    public class SpawnManager : MonoBehaviour
    {
        public int AsteroidSpawnDelay;
        public float clock;
    
        private void Update()
        {
            clock += Time.deltaTime;
            if (clock <= AsteroidSpawnDelay) return;
            var asteroidStatus = new AsteroidStatus(1, 1, 1);  
            SpawnAsteroid(asteroidStatus, transform.localPosition);
            clock = 0;
        }

        private static void SpawnAsteroid(AsteroidStatus asteroid, Vector3 local)
        {
            var prefab = Resources.Load<GameObject>("Prefabs/Asteroid");
            prefab.GetComponent<ConstantForce2D>().force = new Vector2(Random.Range(-0.5F,0.5F), 0);
            prefab.GetComponent<ConstantForce2D>().relativeForce = new Vector2(Random.Range(-0.5F,0.5F), Random.Range(-0.5F,0.5F));
            Instantiate(prefab, local, Quaternion.identity);
        }

    }
}
