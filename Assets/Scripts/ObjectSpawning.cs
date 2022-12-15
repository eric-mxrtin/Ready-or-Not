using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Class <c>ObjectSpawning</c> randomly places objects all over map.
/// </summary>
public class ObjectSpawning : MonoBehaviour
{

    /// <summary>
    /// Holds game objects to be spawned in
    /// </summary>
    public GameObject[] elementPrefab;

    /// <value>
    /// Property <c>objectCount</c> represents the number of objects to be generated.
    /// </value>
    public int objectCount;

    // Update is called once per frame
    /// <summary>
    /// Spawns in objects within a certain range
    /// </summary>
    void Start()
    {
        for (int i = 1; i <= objectCount; i ++)
        {
            Vector2 spawnPos = new Vector2(Random.Range(-3.9f, 4.1f), Random.Range(-3.5f, 4.5f)); // Creates a random position for each object in the list
            Instantiate(elementPrefab[Random.Range(0, elementPrefab.Length)], spawnPos, Quaternion.identity); // Creates the object       
        }
    }
}