using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawning : MonoBehaviour
{

    public GameObject[] elementPrefab;
    public int objectCount;

    // Update is called once per frame
    void Start()
    {
        for (int i = 1; i <= objectCount; i ++)
        {
            Vector2 spawnPos = new Vector2(Random.Range(-4f, 4f), Random.Range(-4f, 4f));
            Instantiate(elementPrefab[Random.Range(0, elementPrefab.Length)], spawnPos, Quaternion.identity);
        }
    }
}
