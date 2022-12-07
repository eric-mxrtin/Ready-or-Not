using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class HealthSystem : MonoBehaviour
{
    public GameObject[] hearts;
    public int life;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(InvokeMethod(TakeDamage,3, 3));
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void TakeDamage()
    {
        life -= 1;
        Destroy(hearts[life].gameObject);
        if (life <= 0)
        {
            SceneManager.LoadScene("Main Menu");
        }
    }

    public IEnumerator InvokeMethod(Action method, float interval, int invokeCount)
    {
        yield return new WaitForSeconds(interval);
        for (int i = 0; i < invokeCount; i++)
        {
            method();

            yield return new WaitForSeconds(interval);
        }
    }
}
