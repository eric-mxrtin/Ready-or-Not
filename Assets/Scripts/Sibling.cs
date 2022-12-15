using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sibling : MonoBehaviour
{

    public Player playerScript;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (playerScript.totemsCollected == 1) {
            Debug.Log("escaping");
            Destroy(this.gameObject);
        }
    }
}
