using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathPlane : MonoBehaviour
{
    public GameObject player;
    Vector3 playerPosition;
    // Start is called before the first frame update
    void Start()
    {
        playerPosition = player.transform.position;
    }

    // Update is called once per frame
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            player.transform.position = playerPosition;
        }
        
    }
}
