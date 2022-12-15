using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sibling : MonoBehaviour
{

    public Player playerScript;
    // Update is called once per frame
    void Update()
    {
        if (playerScript.totemsCollected == 7) {
            Debug.Log("escaping");
            Destroy(this.gameObject);
        }
    }
}
