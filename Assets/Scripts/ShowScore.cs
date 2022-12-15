using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


/// <summary>
/// Class <c>ShowScore</c> is used to update player score
/// </summary>
public class ShowScore : MonoBehaviour
{
    /// <summary>
    /// Initializes string component to define future variables
    /// </summary>
    public string textValue;
    /// <summary>
    /// Initializes element that can take multiple forms of text
    /// </summary>
    public TextMeshProUGUI textElement;

    // Update is called once per frame
    /// <summary>
    /// Updates score for the player every frame
    /// </summary>
    void Update()
    {
        textElement.text = textValue; 
        textElement.text = "Highscore: " + PlayerPrefs.GetFloat("HighScore", 1000000f).ToString() + " seconds";
    }
}
