using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject[] enemyTypes;
    public Transform[] enemySpawners;
    public float difficult;
    private float btwnSpawnTime = 2f;
    private float speedUpTimerDelta = 0.1f;
    private float timerMinimum = 0.5f;
    

    [HideInInspector] public List<GameObject> enemies;
    [HideInInspector] public static List<int> enemyCosts = new List<int>() {7, 12, 30};

    public bool spawned;

    private void Start() 
    {
        StartCoroutine(spawnEnemyType());
        StartCoroutine(Difficult());
    }


    IEnumerator spawnEnemyType()
    {
        while(spawned)
        {
            foreach(Transform spawner in enemySpawners)
            {
                int rand = Random.Range(0, 11);
                if(rand < 7)
                {
                    GameObject enemyType = enemyTypes[0];             
                    GameObject enemy = Instantiate(enemyType, spawner.position, Quaternion.identity) as GameObject;
                    enemy.transform.parent = transform;
                    enemies.Add(enemy);
                }
                if(rand > 6 && rand < 10)
                {
                    GameObject enemyType = enemyTypes[1];
                    GameObject enemy = Instantiate(enemyType, spawner.position, Quaternion.identity) as GameObject;                   
                    enemy.transform.parent = transform;
                    enemies.Add(enemy);
                }
                if(rand > 9)
                {
                    GameObject enemyType = enemyTypes[2];
                    GameObject enemy = Instantiate(enemyType, spawner.position, Quaternion.identity) as GameObject;              
                    enemy.transform.parent = transform;
                    enemies.Add(enemy);
                }
                yield return new WaitForSeconds(btwnSpawnTime);
            }
        }
    }

    IEnumerator Difficult()
    {
        while (btwnSpawnTime > timerMinimum)
        {
            btwnSpawnTime -= speedUpTimerDelta;
            if (btwnSpawnTime < timerMinimum)
            {
                btwnSpawnTime = timerMinimum;
            }
            Debug.Log(btwnSpawnTime);
            yield return new WaitForSeconds(difficult); 
        }
    }   
}
