using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TotemSpawning : MonoBehaviour
{

    public GameObject[] elementPrefab;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < elementPrefab.Length; i ++) {
            Vector2 spawnPos = new Vector2(Random.Range(-3.9f, 4.1f), Random.Range(-3.5f, 4.5f));
            Instantiate(elementPrefab[i], spawnPos, Quaternion.identity);
        }
    }
}
