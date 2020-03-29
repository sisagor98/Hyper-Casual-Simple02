using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spanwer : MonoBehaviour
{

    public float SpawnerDelay = 0.85f;
    public GameObject RocketPrefabs;
    private float nextTimeToSpawner;

    // Update is called once per frame
    void Update()
    {
        if(nextTimeToSpawner <= Time.time)
        {
            Spawn();

            nextTimeToSpawner = Time.time + SpawnerDelay;
        }
    }

    void Spawn()
    {
        Instantiate(RocketPrefabs, transform.position, transform.rotation);
    }

  /*  private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "destroy")
        {
            Destroy(gameObject);
        }

    }*/
}
