using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D plBody;

    public GameObject resumeButton;

    [SerializeField]
    private float jumpforce = 10f;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        resumeButton.SetActive(true);
    }

    private void Update() {
        
        playerJump();
    }
    void playerJump()
    {
        if(Input.GetMouseButtonDown(0))
        {
            plBody.AddForce(new Vector2(0f, jumpforce), ForceMode2D.Impulse);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        if(collision.gameObject.CompareTag("Danger"))
        {
            Time.timeScale = 0;
            GameOverManager.gameOver = true;
            resumeButton.SetActive(false);

        }
    }
    
}
