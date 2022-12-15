using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShowCoins : MonoBehaviour
{
    public string textValue;
    public TextMeshProUGUI textElement;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        textElement.text = textValue; 
        textElement.text = "Coins: " + PlayerPrefs.GetInt("coins", 0).ToString();
    }
}
