using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitDetector : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Game Over
        //Debug.Log("\nGame Over\n");
        FindObjectOfType<Level>().LoadGameOver();
        // freeze player
        Bird bird = FindObjectOfType<Bird>();
        bird.SetGameOver(true);
    }
}
