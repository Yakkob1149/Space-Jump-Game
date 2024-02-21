using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levels : MonoBehaviour
{
    public GameObject platformPrefab;
    public int numberOfPlatforms = 200;
    public float levelWidth = 3f;
    public float minh = 0.2f;
    public float maxh = 1.5f;

    void Start()
    {
        Vector3 spawnPosition = new Vector3();
        for (int i = 0; i < numberOfPlatforms; i++)
        {
            spawnPosition.y += Random.Range(minh, maxh);
            spawnPosition.x = Random.Range(-levelWidth, levelWidth);
            Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
        }
    }
    void Update()
    {
        
    }
}
