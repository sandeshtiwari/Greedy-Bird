using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] float velocityIncreaseRate = 0.0005f;
    [SerializeField] float velocity = 0.01f;
    [SerializeField] float xPosPadding = 50f;
    [SerializeField] float yPosInnerPadding = 0.2f;

    // Start is called before the first frame update
    void Start()
    {
        SetVelocity();
    }

    // Update is called once per frame
    void Update()
    {
        velocity += velocityIncreaseRate;
        SetVelocity();
    }

    public void SetVelocity()
    {
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(-velocity, 0);
        // Debug.Log(velocity);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        float minY = Camera.main.ScreenToWorldPoint(new Vector2(0, yPosInnerPadding)).y;
        float maxY = Camera.main.ScreenToWorldPoint(new Vector2(0, Screen.height - yPosInnerPadding)).y;
        float newX = Camera.main.ScreenToWorldPoint(new Vector2(1, 0)).x + xPosPadding;
        float newY = Random.Range(minY, maxY);
        Debug.Log("X = " + newX + " Y = " + newY);
        transform.position = new Vector2(newX, newY);
        gameObject.GetComponent<Collider2D>().isTrigger = true;
        if (other.GetComponent<Bird>())
        {
            Bird bird = other.GetComponent<Bird>();
            bird.IncreaseScore();
            bird.IncreaseGravity();
        }
    }

   
}
