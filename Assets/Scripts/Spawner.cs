using System.Collections;
using UnityEngine;
using UnityEngine.Serialization;

public class Spawner : MonoBehaviour
{
    [SerializeField] private float spawnTime;
    [SerializeField] private GameObject spawnObject;
    private float spawnedTime;

    private void Awake()
    {
        spawnedTime = spawnTime;
    }

    private void Update()
    {
        spawnTime -= Time.deltaTime;
        
        if (spawnTime <= 0)
        {
            StartCoroutine(Spawn());
        }
    }

    IEnumerator Spawn()
    {
        yield return new WaitForSeconds(spawnTime);
        Instantiate(spawnObject, transform.position, Quaternion.identity); 
        spawnTime = spawnedTime;
    }
}
