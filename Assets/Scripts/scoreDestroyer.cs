using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scoreDestroyer : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D collision) {

        if(collision.gameObject.CompareTag("Player"))
        {
           // Destroy(gameObject);

            ScoreManager.instance.AddScore();
        }
    }
}
