using System.Collections;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject EnemyPrefab;
    [SerializeField] private GameObject EnemyBossPrefab;
    [SerializeField] private float swarmerInterval = 3.5f;
    [SerializeField] public int EnemyMaxSpawnCount;

    private int currentEnemySpawnCount = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(spawnEnemy(swarmerInterval, EnemyPrefab));   
    }

    void Update()
    {
        bossSpawn();
    }

    void bossSpawn()
    {
        if (Boss.goalReached)
        {
            
            GameObject newBoss = Instantiate(EnemyBossPrefab, new Vector3(Random.Range(-5f, 5), Random.Range(-6f, 6f), 0), Quaternion.identity);
            Boss.goalReached = false;
        }
    }
        

private IEnumerator spawnEnemy(float interval, GameObject enemy)
    {
        
        yield return new WaitForSeconds(interval);

        if (currentEnemySpawnCount < EnemyMaxSpawnCount && !Boss.goalReached)
        {
            GameObject newEnemy = Instantiate(enemy, new Vector3(Random.Range(-5f, 5), Random.Range(-6f, 6f), 0), Quaternion.identity);
            currentEnemySpawnCount++;
            StartCoroutine(spawnEnemy(interval, enemy));
        }
    }   
}
