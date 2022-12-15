using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Class <c>TotemSpawning</c> randomly generates totems for collection.
/// </summary>
public class TotemSpawning : MonoBehaviour
{

    /// <summary>
    /// Stores totem objects to be used
    /// </summary>
    public GameObject[] elementPrefab;

    // Start is called before the first frame update
    /// <summary>
    /// Randomly spawns totems around the map
    /// </summary>
    void Start()
    {
        for (int i = 0; i < elementPrefab.Length; i ++) {
            Vector2 spawnPos = new Vector2(Random.Range(-3.9f, 4.1f), Random.Range(-3.5f, 4.5f)); // Creates a random position for each object in the list
            Instantiate(elementPrefab[i], spawnPos, Quaternion.identity); // Creates the object   
        }
    }
}