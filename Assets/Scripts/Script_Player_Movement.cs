using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_Player_Movement : MonoBehaviour
{
    private Rigidbody rb;
    float player_speed = 5;
    float rotation1 = 0;
    Vector3 direction;
    public float sensibility = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Rotation();
    }


    void Rotation()
    {
        float mouseX = Input.GetAxis("Mouse X");
     
        rotation1 += mouseX;
        rotation1 = Mathf.Clamp(rotation1, -90f, 90f);
        transform.eulerAngles = new Vector3(0, rotation1, 0);

    }

    private void Move()
    {
        direction = new Vector3();
        if (Input.GetKey("w"))
        {
            direction += Vector3.forward;

        }
        if (Input.GetKey("a"))
        {
            direction += Vector3.left;

        }
        if (Input.GetKey("s"))
        {
            direction += Vector3.back;

        }
        if (Input.GetKey("d"))
        {

            direction += Vector3.right;
        }
        rb.velocity = direction.normalized * player_speed;
    }



}
