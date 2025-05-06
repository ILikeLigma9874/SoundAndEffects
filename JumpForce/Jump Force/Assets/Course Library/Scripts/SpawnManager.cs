using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] obstaclePrefab;
    private int objectIndex;
    public float startDelay;
    public float repeatRate;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObstacle ()
    {
        Instantiate(obstaclePrefab[objectIndex], new Vector3(29, Random.Range((int)-2.2, (int)-2.2), 0), obstaclePrefab[objectIndex].transform.rotation);
        objectIndex = Random.Range(0, obstaclePrefab.Length);
    }
}
