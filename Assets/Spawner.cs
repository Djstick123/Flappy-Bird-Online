using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefab;
    public float nextSpawnTime;
    public float spawnInterval;
    
    private void Update()
    {
        if (Time.time > nextSpawnTime)
        {
            Spawn();
            nextSpawnTime += spawnInterval;
        }
    }


    void Spawn()
    {
        var pos = transform.position;
        pos.y = Random.Range(-1f, 1f);
        var rot = Quaternion.Euler(0, 0, 0);
        
        Instantiate(prefab,pos,rot);
    }
}
