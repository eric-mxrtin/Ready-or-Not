using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

/// <summary>
/// Class <c>ShowCoins</c> is used to update player coins
/// </summary>
public class ShowCoins : MonoBehaviour
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
    /// Updates coins collected by player every frame
    /// </summary>
    void Update()
    {
        textElement.text = textValue; 
        textElement.text = "Coins: " + PlayerPrefs.GetInt("coins", 0).ToString();
    }
}
