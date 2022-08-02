using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    public GameObject prefab;
    public float delayBulletSpawn = 2f;
    public float intervalBulletSpawn = 1f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnBullet", delayBulletSpawn, intervalBulletSpawn);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnBullet()
    {
        Instantiate(prefab, transform);
    }
}
