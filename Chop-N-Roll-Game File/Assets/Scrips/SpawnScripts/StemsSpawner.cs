using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StemsSpawner : MonoBehaviour {

    public GameObject WeedStem;
    public Transform[] spawnPoints;

    public float minDelay = .1f;
    public float maxDelay = 1f;

    // Use this for initialization
    void Start () {
        StartCoroutine(SpawnFruits());
    }

    IEnumerator SpawnFruits ()
    {
        while (true)
        {
            float delay = Random.Range(minDelay, maxDelay);
            yield return new WaitForSeconds(delay);

            int spawnIndex = Random.Range(0, spawnPoints.Length);
            Transform spawnPoint = spawnPoints[spawnIndex];

            GameObject spawnedFruit = Instantiate(WeedStem, spawnPoint.position, spawnPoint.rotation);
            Destroy(spawnedFruit, 5f);
        }
    }
    
}