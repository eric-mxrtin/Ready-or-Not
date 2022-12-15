using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Continue : MonoBehaviour
{
    /// <summary>
    /// Opens main manu user interface scene
    /// </summary>
    public void mainMenu()
    {
        SceneManager.LoadScene("Main Menu"); 
    }
}
