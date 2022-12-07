using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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
        float minutes = Mathf.FloorToInt(currentTime / 60);
        float seconds = Mathf.FloorToInt(currentTime % 60);
        countdownText.GetComponent<TMPro.TextMeshProUGUI>().text = string.Format("{0:00}:{1:00}", minutes, seconds);
        }

        if(currentTime <= 0)
        {
            currentTime = 0;
            timerIsActive = false;
            SceneManager.LoadScene("Main Menu");

        }


    }   

}
