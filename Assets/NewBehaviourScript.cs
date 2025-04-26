using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Test : MonoBehaviour
{
    int s = 0;
    Test d;
    BoxCollider gh;
    public Rigidbody rb;
    public Transform pos;


    // Start is called before the first frame update
    void Start()
    {
        Vector3 dir = new Vector3(0, 0, 0);
        

    }
        // Update is called once per frame
        void Update()
        {
        Camera.main.transform.position = pos.position - new Vector3(-10,-10,0);
            if (Input.GetKeyDown(KeyCode.Space))
            {
                rb.AddForce(new Vector3(0, 100, 0));

            }
            if (Input.GetKey(KeyCode.W))
            {
                rb.AddForce(new Vector3(-10, 0, 0));

            }
            if (Input.GetKey(KeyCode.S))
            {
                rb.AddForce(new Vector3(10, 0, 0));

            }
            if (Input.GetKey(KeyCode.A))
            {
                rb.AddForce(new Vector3(0, 0, -10));

            }
            if (Input.GetKey(KeyCode.D))
            {
                rb.AddForce(new Vector3(0, 0, 10));

            }


        }
    }
