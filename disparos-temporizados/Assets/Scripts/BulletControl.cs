using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletControl : MonoBehaviour
{
    public float speed = 2f;
    public float liveTimeBullet = 4f;
    void Start()
    {
        Invoke("DestroyBullet", liveTimeBullet);
    }

   
    void Update()
    {
        Move();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            DuplicateScale();
        }

    }

    void Move()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    void DestroyBullet()
    {
        Destroy(gameObject);
    }

    void DuplicateScale()
    {
        transform.localScale *= 2;
    }
}
