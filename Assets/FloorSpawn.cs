using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorSpawn : MonoBehaviour
{
    public GameObject floor;

    private float y = -5;
    private static float x;
    // Start is called before the first frame update
    void Start()
    {
        x = 0;//floor.transform.position.x;
        InvokeRepeating("SpawnFloor", 0, 5.5F);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SpawnFloor()
    {
        x += 22;
        GameObject tempFloor = Instantiate(floor, new Vector3(x, y, 0), transform.rotation);
        Destroy(tempFloor, 10);
    }
}
