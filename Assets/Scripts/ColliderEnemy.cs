using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderEnemy : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "rocket")
        {
            //Debug.Log("other.name");
            other.gameObject.transform.parent = transform;
            other.gameObject.SetActive(false);
        }
    }
}
