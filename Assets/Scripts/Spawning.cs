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
            Vector2 spawnPos = new Vector2(Random.Range(-3.9f, 4.1f), Random.Range(-3.5f, 4.5f));
            Instantiate(elementPrefab[Random.Range(0, elementPrefab.Length)], spawnPos, Quaternion.identity);
        }
    }
}
