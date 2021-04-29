using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_Controller : MonoBehaviour
{

    private Rigidbody rbBullet;
    public float bulletSpeed=5;
    private GameManagerScript pointsCounter;
    

    // Start is called before the first frame update
    void Start()
    {
        rbBullet = GetComponent<Rigidbody>();
        rbBullet.velocity = transform.forward * bulletSpeed;
        pointsCounter = FindObjectOfType<GameManagerScript>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Enemy"))
        {
            // Stelle für die Puntenzähler-Funktion
            
            pointsCounter.SetPoints();
        }


        // Bullet verschwindet

        Destroy(gameObject);
        
    }



}
