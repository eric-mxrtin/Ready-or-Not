using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int totemsCollected = 0;
    public GameObject[] totems;
    void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.tag == "Totem") {
            Destroy(other.gameObject);
            Destroy(totems[totemsCollected].gameObject);
            totemsCollected ++;
            if (totemsCollected == 7) {
                // unlock portal
            }
            Debug.Log(totemsCollected);
        }
    }
}
