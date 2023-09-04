using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    [SerializeField]
    private float speed=2f;

    [SerializeField]
    private int destSec =10;

    [SerializeField]
    private Rigidbody2D obsBody;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        obsBody.velocity = -(new Vector2(speed, obsBody.velocity.y));
        StartCoroutine(DestroyGameObj());
        
    }
    IEnumerator DestroyGameObj()
    {
        yield return new WaitForSeconds(destSec);
        Destroy(gameObject);
    }
}