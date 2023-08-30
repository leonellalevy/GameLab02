using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapMovement : MonoBehaviour
{
    public float speed = 5.0f;
    Rigidbody rigidBody;
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Quaternion deltaRotation = Quaternion.Euler(new Vector3(0,1,0)* Time.fixedDeltaTime * speed);
        rigidBody.MoveRotation(rigidBody.rotation * deltaRotation);
        //transform.Rotate(new Vector3(0,1,0) * Time.deltaTime * speed);

    }
}
