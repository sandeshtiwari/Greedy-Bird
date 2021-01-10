using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    [SerializeField] SpriteRenderer bird;
    [SerializeField] float jumpStrength = 5f;
    [SerializeField] float gravityStrengthIncreaseRate = 0.1f;
    [SerializeField] float jumpStrengthIncreaseRate = 0.5f;
    [SerializeField] float xLeftPadding = -8f;
    float paddingFactor = 100f;
    bool gameOverScreen = true;

    

    // Start is called before the first frame update
    void Start()
    {
        transform.position = Camera.main.ScreenToViewportPoint(new Vector2(xLeftPadding * paddingFactor, Screen.height));
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = Camera.main.ScreenToViewportPoint(new Vector2(xLeftPadding * paddingFactor, 1));
        if (Input.GetButtonDown("Fire1") && gameOverScreen)
        {
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0, jumpStrength);
        }
    }

    

    public void IncreaseGravity()
    {
        gameObject.GetComponent<Rigidbody2D>().gravityScale += gravityStrengthIncreaseRate;
    }

    public void IncreaseJumpStrength()
    {
        gameObject.GetComponent<Bird>().jumpStrength += jumpStrengthIncreaseRate;
    }

    

    public void SetGameOver(bool gameOver)
    {
        gameOverScreen = gameOver;
    }
}
