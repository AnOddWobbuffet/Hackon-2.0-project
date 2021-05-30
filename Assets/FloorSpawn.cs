using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorSpawn : MonoBehaviour
{
    public GameObject floor;
    public GameObject[] obstacles;

    private float y = -5;
    private static float x;
    private static float platformX;
    private static float destroyTimer = 20;
    // Start is called before the first frame update
    void Start()
    {
        x = 0;
        platformX = 0;
        InvokeRepeating("SpawnFloor", 0, 4f);
        InvokeRepeating("SpawnObstacles", 0, 4f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SpawnFloor()
    {
        x += 20;
        GameObject tempFloor = Instantiate(floor, new Vector3(x, y, 0), transform.rotation);
        Destroy(tempFloor, destroyTimer);
    }

    private void SpawnObstacles()
    {
        platformX += 22;
        int number = Random.Range(0, obstacles.Length);
        GameObject obstacle = Instantiate(obstacles[number], new Vector3(platformX, obstacles[number].transform.position.y, 0), transform.rotation);
        Destroy(obstacle, destroyTimer);
        destroyTimer += 0.3f;
    }
}
