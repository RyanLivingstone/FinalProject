using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public int EnemyAmount = 5;
    public GameObject enemyPrefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SpawnEnemies();
    }
    
    void SpawnEnemies(){
        GameObject[] ground = GameObject.FindGameObjectsWithTag("Ground");

        for (int i = 0; i < EnemyAmount; i++)
        {
            GameObject randomGround = ground[Random.Range(0, ground.Length)];

            Vector3 spawnPos = randomGround.transform.position;

            Instantiate(enemyPrefab, spawnPos, Quaternion.identity);
        }
    }
}
