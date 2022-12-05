using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ActivatePortal : MonoBehaviour
{
    
    public Sprite PortalOn;
    public int activateTime;
    public bool isPortalOn;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("turnOnPortal", activateTime);
    }

    // // Update is called once per frame
    // void Update()
    // {

    // }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (isPortalOn == true)
        {
            SceneManager.LoadScene("Main Menu");
        }

    }

    void turnOnPortal()
    {
        this.gameObject.GetComponent<SpriteRenderer>().sprite = PortalOn;
        isPortalOn = true;
    }
}
