using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour
{
    Text scoreText;
    Bird birdObject;
    // Start is called before the first frame update
    void Start()
    {
        scoreText = GetComponent<Text>();
        birdObject = FindObjectOfType<Bird>();
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = birdObject.GetScore().ToString();
    }
}
