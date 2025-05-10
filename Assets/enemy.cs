using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public Transform player;
    public CharacterController characterController;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<bullet>() != null)
        {
            //Destroy(gameObject);
            gameObject.SetActive(false);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, player.position, 0.15f);
        //characterController.Move(player.position);

    }
}
