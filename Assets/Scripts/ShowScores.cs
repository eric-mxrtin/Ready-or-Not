using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using TMPro;

public class ScowScores : MonoBehaviour
{

    public string textValue;
    public TextMeshProUGUI textElement;
    public Player playerInfo;

    // Update is called once per frame
    void Update()
    {
        textElement.text = string.Format("{0:N5}", PlayerPrefs.GetFloat("HighScore"));
    }
}
