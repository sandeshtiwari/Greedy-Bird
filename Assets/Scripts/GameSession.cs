using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSession : MonoBehaviour
{
    int score = 0;
    private void Awake()
    {
        SetUpSingleton();
    }

    private void SetUpSingleton()
    {
        int numberGameSessions = FindObjectsOfType<GameSession>().Length;
        if (numberGameSessions > 1)
        {
            Destroy(gameObject);
            //Debug.Log("Do "+ FindObjectOfType<GameSession>().GetScore());
        }
        else
        {
           // Debug.Log("DON'T");
            DontDestroyOnLoad(gameObject);
        }
    }

    public int GetScore()
    {
        return score;
    }

    public void IncreaseScore()
    {
        score++;
        //Debug.Log("Current Score "+score);
    }

    public void ResetGame()
    {
        //gameObject.GetComponent<GameSession>().score = 0;
        Destroy(gameObject);
        //score = 0;
        //Debug.Log(score);
    }
}
