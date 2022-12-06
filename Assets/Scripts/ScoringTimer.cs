using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoringTimer : MonoBehaviour
{
   public float currentTime = 0f;
   public float startingTime = 10f;
   public bool timerIsActive = true;
   public GameObject countdownText;

    // Start is called before the first frame update
    void Start()
    {
       currentTime = startingTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (timerIsActive)
        {
        currentTime -= 1 * Time.deltaTime;
        countdownText.GetComponent<TMPro.TextMeshProUGUI>().text = currentTime.ToString("F1");
        }

        if(currentTime <= 0)
        {
            currentTime = 0;
            timerIsActive = false;
        }
    }   

}
