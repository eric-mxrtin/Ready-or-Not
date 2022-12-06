using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ActivatePortal : MonoBehaviour
{
    
    public Sprite PortalOn;
    public int activateTime;
    public bool isPortalOn;
    
    //public bool IsTouching(Collider2D collider, ContactFilter2D contactFilter);
    // Start is called before the first frame update
    void Start()
    {
        Invoke("turnOnPortal", activateTime);
    }

    // Update is called once per frame
    // void Update()
    // {
    //     if (this.IsTouching(other)) && (isPortalOn == true)
    //     {
    //         SceneManager.LoadScene("Main Menu");
    //     }
    // }
    void OnTriggerEnter2D(Collider2D other) 
    {
        SceneManager.LoadScene("Main Menu"); 
    }

    void turnOnPortal()
    {
        this.gameObject.GetComponent<SpriteRenderer>().sprite = PortalOn;
        isPortalOn = true;
        this.gameObject.GetComponent<Collider2D>().isTrigger = true;
    }
    

}
