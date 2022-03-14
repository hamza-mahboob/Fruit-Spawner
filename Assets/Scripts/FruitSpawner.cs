using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitSpawner : MonoBehaviour
{
    public GameObject[] fruits;
    float xBound, zBound;
    int startDelay, repeatDelay;

    // Start is called before the first frame update
    void Start()
    {
        xBound = zBound = 10;

        startDelay = repeatDelay = 2;

        InvokeRepeating("SpawnRandomFruit", startDelay, repeatDelay);
    }

    void SpawnRandomFruit()
    {
        //random index
        int randomIndex = Random.Range(0, fruits.Length);

        //random x & z
        float randomX = Random.Range(-xBound, xBound);
        float randomZ = Random.Range(-zBound, zBound);

        //random position
        Vector3 randomPos = new Vector3(randomX, 1, randomZ);

        //instantiate random fruit on random position
        Instantiate(fruits[randomIndex], randomPos, Quaternion.identity);
    }
}
