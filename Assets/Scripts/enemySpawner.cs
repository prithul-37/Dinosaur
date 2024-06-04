using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawner : MonoBehaviour
{   
    private bool willSpawn = true;
    public GameObject[] gameObjects;
    public int enemyPerPlatform = 3;
    private float timer = 0f;
    private int enemyCount = 0;
    //public Transform transform;
    

    // Start is called before the first frame update
    void Start()
    {  
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (willSpawn && timer>=2.0 && enemyCount<enemyPerPlatform)
        {
            Instantiate(gameObjects[Random.Range(0,gameObjects.Length)],transform.position,transform.rotation);
            enemyCount++;
            timer = 0f;
        }
    }
    
    public void will_Spawn()
    {
        willSpawn = true;
    }
}
