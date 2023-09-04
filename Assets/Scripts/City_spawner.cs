using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class City_spawner : MonoBehaviour
{
    [SerializeField]
    private GameObject objRef;

    [SerializeField]
    private Transform spawnPosition;

    private GameObject spawnedCity;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnCityObj());        
    }

    IEnumerator SpawnCityObj()
    {
        while(true)
        {
            yield return new WaitForSeconds(9);

            spawnedCity = Instantiate(objRef);

            spawnedCity.transform.position = spawnPosition.position;
        }
    }
}
