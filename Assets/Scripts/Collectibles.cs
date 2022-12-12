using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectibles : MonoBehaviour
{
    void onTriggerEnter(Collider other) 
    {
        if (other.tag == "Player") {
            Destroy(this.gameObject);
        }
    }
}
