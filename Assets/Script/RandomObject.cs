using UnityEngine;
using System.Collections;

public class RandomObject : MonoBehaviour
{

    public float spawnTime = 5f;		// The amount of time between each spawn.
    public float spawnDelay = 3f;

    public Vector3 spawnValues;
    public GameObject[] spawnList = new GameObject[0];

    void Start()
    {
        InvokeRepeating("Spawn", spawnDelay, spawnTime);
    }

    void Spawn()
    {
        int index = Random.Range(0, spawnList.Length);
        Vector3 spawnPosition = new Vector3(spawnList[index].transform.position.x, spawnList[index].transform.position.y, spawnList[index].transform.position.z);
        Instantiate(spawnList[index], spawnPosition, spawnList[index].transform.rotation);
    }

    //void Update()
    //{
    //    if (spawnList.Length <= 0)
    //    {
    //        return;
    //    }
    //    int index = Random.Range(0, spawnList.Length);
    //    if (spawnList[index] == null)
    //    {
    //        return;
    //    }
    //    Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), spawnValues.y, spawnList[index].transform.position.z);
    //    Instantiate(spawnList[index], spawnPosition, spawnList[index].transform.rotation);
    //}
}
