using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab;
    [SerializeField] private float spawnRange = 9.0f; 
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemy", 2f, 5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private Vector3 RandomPosotion()
    {
        float randomX = Random.Range(-spawnRange, spawnRange);
        float randomY = Random.Range(-spawnRange, spawnRange);
        Vector3 randomPos = new Vector3(randomX, 0, randomY);
        return randomPos;
    }

    private void SpawnEnemy()
    {
        Instantiate(enemyPrefab, RandomPosotion(), enemyPrefab.transform.rotation);
    }

}
