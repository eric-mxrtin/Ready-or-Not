using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShowScore : MonoBehaviour
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
        textElement.text = "Highscore: " + PlayerPrefs.GetFloat("HighScore", 1000000f).ToString() + " seconds";
    }
}
