using UnityEngine;

public class CarSpawner : MonoBehaviour
{
    public float spawndelay = 0.3f;

    float nextTimeToSpawn = 0f;

    public GameObject car;

    public Transform spawnpoint;

    private void Update()
    {
        if (nextTimeToSpawn <= Time.time)
        {
            SpawnCar();
            nextTimeToSpawn = Time.time + spawndelay;
        }
    }

    void SpawnCar()
    {
        Instantiate(car, spawnpoint.transform.position, car.transform.rotation);
    }
} 
