using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectilespawner : MonoBehaviour
{
    public GameObject enemyProjectile;
    public float spawnTimer;
    public float spawnmax = 10;
    public float spawnmin = 5;
    // Start is called before the first frame update
    void Start()
    {
        spawnTimer = Random.Range(spawnmin, spawnmax);
    }

    // Update is called once per frame
    void Update()
    {
        {
            spawnTimer -= Time.deltaTime;
            if(spawnTimer <= 0)
            {
                spawnTimer = Random.Range(spawnmin, spawnmax);
                Instantiate(enemyProjectile, transform.position, Quaternion.identity);

            }
        }
    }
}
