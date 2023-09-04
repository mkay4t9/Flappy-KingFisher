using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle_spawner : MonoBehaviour
{
    [SerializeField]
    private Transform obsPos;

    [SerializeField]
    private GameObject obsRef;

    private GameObject spawnedCity;

    private int randomYpos;
    void Start()
    {
        StartCoroutine(spawnObs());
    }

    IEnumerator spawnObs()
    {
        while(true)
        {
            yield return new WaitForSeconds(2);

            spawnedCity = Instantiate(obsRef);
            randomYpos = Random.Range(-3,2);
            transform.position = new Vector3(4, randomYpos, -8);
            spawnedCity.transform.position = obsPos.position;
        }
    }
}
