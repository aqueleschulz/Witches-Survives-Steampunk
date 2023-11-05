using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPipes : MonoBehaviour
{
    public GameObject pipes;
    public bool canSpawn;
    public float spawnRate;
    public float heighOffset = 5;
    private float timer = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            SpawnPipe();
            timer = 0;
        }
    }

    void SpawnPipe()
    {
        if(!canSpawn)
        return;
        
        float lowestPoint = transform.position.y - heighOffset;
        float highestPoint = transform.position.y + heighOffset;

        Instantiate(pipes, new Vector3(transform.position.x, Random.Range(lowestPoint,
        highestPoint), 0), transform.rotation);
    }
    
    public void UpdateBool(Component sender, object data)
    {
        if(data is bool)
        {
            canSpawn = (bool) data;
        }
    }
}
