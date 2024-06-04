using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformSpawnner : MonoBehaviour
{
    public GameObject platform;
    public Transform spawnPoint;
    public float spawnTime;
    private float timer = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= spawnTime)
        {
            GameObject gg =  Instantiate(platform,spawnPoint.position,spawnPoint.rotation);
            gg.GetComponentInChildren<enemySpawner>().will_Spawn();
            timer = 0f;
        }
    }
}
