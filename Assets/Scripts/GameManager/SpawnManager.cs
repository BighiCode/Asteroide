using CorposCelestes.Asteroides;
using UnityEngine;

namespace GameManager
{
    public class SpawnManager : MonoBehaviour
    {
        public GameObject AsteroidModel; 
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

        private void SpawnAsteroid(AsteroidStatus asteroid, Vector3 local)
        {
            var instance = Instantiate(AsteroidModel, local, Quaternion.identity);
            instance.GetComponent<ConstantForce2D>().force = new Vector2(Random.Range(-0.5F,0.5F), 0);
            instance.GetComponent<ConstantForce2D>().relativeForce = new Vector2(Random.Range(-0.5F,0.5F), Random.Range(-0.5F,0.5F));
            instance.GetComponent<Asteroid>().Status.Size = Random.Range(1, 4);
            instance.GetComponent<Asteroid>().Status.Life = 2;
        }
    }
}
