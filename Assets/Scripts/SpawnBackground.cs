using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBackground : MonoBehaviour
{
    public GameObject cloud;
    public GameObject[] building;

    public float heighOffset = 1;

    public float cloudsSpawnRate;
    public float buildingsSpawnRate;
    
    private float cloudsTimer = 0;
    private float buildingsTimer = 0;

    // Start is called before the first frame update
    void Start()
    {
        SpawnCloud();
        SpawnBuilding();
    }

    // Update is called once per frame
    void Update()
    {
        if(cloudsTimer < cloudsSpawnRate)
        {
            cloudsTimer += Time.deltaTime;
        }
        else
        {
            SpawnCloud();
            cloudsTimer = 0;
        }

        if(buildingsTimer < buildingsSpawnRate)
        {
            buildingsTimer += Time.deltaTime;
        }
        else
        {
            SpawnBuilding();
            buildingsTimer = 0;
        }
    }

    public void SpawnCloud()
    {
        Instantiate(cloud, new Vector3(15,
            cloud.transform.position.y, transform.position.z), transform.rotation);
    }

    public void SpawnBuilding()
    {
        int i = Random.Range(0, 2);
        float lowestPoint = building[i].transform.position.y - heighOffset;
        float highestPoint = building[i].transform.position.y + heighOffset;

        Instantiate(building[i], new Vector3(transform.position.x, Random.Range(lowestPoint,
        highestPoint), 0), transform.rotation);
    }
}
