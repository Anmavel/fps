using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    // Bullet verschwindet
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.transform)
        {
            Destroy(gameObject);
        }


    }

}
