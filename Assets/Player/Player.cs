using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody _rigidbody;
    public float PlayerVelocity = 10;



    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 velocity = PlayerVelocity * new Vector3(horizontalInput, 0.0f, verticalInput).normalized;
        _rigidbody.velocity = velocity;
    }
}
