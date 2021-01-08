using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    [SerializeField] SpriteRenderer bird;
    [SerializeField] float jumpStrength = 5f;
    [SerializeField] float gravityStrengthIncreaseRate = 0.1f;
    [SerializeField] float jumpStrengthIncreaseRate = 0.5f;
    int score;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0, jumpStrength);
        }
    }

    public void IncreaseScore()
    {
        score++;
        Debug.Log("Current Score "+score);
    }

    public void IncreaseGravity()
    {
        gameObject.GetComponent<Rigidbody2D>().gravityScale += gravityStrengthIncreaseRate;
    }

    public void IncreaseJumpStrength()
    {
        gameObject.GetComponent<Bird>().jumpStrength += jumpStrengthIncreaseRate;
    }
}
