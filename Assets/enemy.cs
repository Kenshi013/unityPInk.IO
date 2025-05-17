using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public Transform player;
    public CharacterController characterController;
    Vector3 startpos;
    GameObject a;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<bullet>() != null)
        {
            //Destroy(gameObject);
            gameObject.SetActive(false);
        }
        if (collision.gameObject.GetComponent<Test>() != null)
        {
            //Destroy(gameObject);
            a = collision.gameObject;
            collision.gameObject.GetComponent<Test>().enabled=false;
            StartCoroutine(relive());

        }
    }  
    IEnumerator relive()
    {
        yield return new WaitForSeconds(5);
        a.GetComponent<Test>().enabled = true; 
        transform.position = startpos;
    }
    // Start is called before the first frame update
    void Start()
    {
        startpos= transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, player.position, 0.05f);
        //characterController.Move(player.position);

    }
}
