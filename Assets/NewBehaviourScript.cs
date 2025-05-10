using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UIElements;
using static UnityEditor.Searcher.SearcherWindow.Alignment;

public class Test : MonoBehaviour
{
    
    int s = 0;
    Test d;
    BoxCollider gh;
    public Rigidbody rb;
    public Transform pos;
    float xRotation = 0;
    public GameObject bullet;
    public Transform point;
    // Start is called before the first frame update
    //private void OnCollisionEnter(Collision collision) 
    //{
    //    //rb.AddForce(new Vector3(0, 200, 0));


    //}
    void Start()
    {
        Vector3 dir = new Vector3(0, 0, 0);
        UnityEngine.Cursor.visible = false;
        UnityEngine.Cursor.lockState = CursorLockMode.Locked;
    }
        // Update is called once per frame
        void Update()
        {
            Transform r = Camera.main.transform;
            rb.velocity = (pos.forward* Input.GetAxis("Vertical") + pos.right * Input.GetAxis("Horizontal")) *5 + new Vector3(0, rb.velocity.y, 0);
            pos.Rotate(0, Input.GetAxis("Mouse X")*2, 0);
            float mouseY = Input.GetAxis("Mouse Y") * 2;
            xRotation -= mouseY;
            xRotation = Mathf.Clamp(xRotation, -90, 90);
            r.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

            if (Input.GetMouseButtonDown(0))
            {
                
                Rigidbody a = Instantiate(bullet,point.position,Quaternion.identity).GetComponent<Rigidbody>();
                Vector3 s = pos.forward * 9;
                a.AddForce(s, ForceMode.Force);
            }

        }
    }
