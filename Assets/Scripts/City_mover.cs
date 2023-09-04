using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class City_mover : MonoBehaviour
{
    [SerializeField]
    private float speed=2f;

    [SerializeField]
    private Rigidbody2D cityBody;

    [SerializeField]
    private GameObject cityGameObj;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cityBody.velocity = -(new Vector2(speed, cityBody.velocity.y));

        StartCoroutine(DestroyGameObj());
        
    }
    IEnumerator DestroyGameObj()
    {
        yield return new WaitForSeconds(10);
        //Destroy(gameObject);
    }
}
