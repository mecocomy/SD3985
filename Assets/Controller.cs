using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    [Range(0, 5f)]
    public float movementSpeed;
    //public float jumpForce;
    //private Rigidbody2D rig;

    // Start is called before the first frame update
    //void Start()
    //{
    //    rig = GetComponent<Rigidbody2D>();
    //}

    // Update is called once per frame
    void Update()
    {
        float xInput = Input.GetAxis("Horizontal");
        float yInput = Input.GetAxis("Vertical");

        transform.position += (new Vector3(xInput, yInput, 0)) * movementSpeed * Time.deltaTime;
        //print(Time.deltaTime);
    }
}
