using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public GameObject cube;
    Rigidbody rb;
    public float speedmodifier;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
    
    private void Move()
    {
        float forward = Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal");

        Vector3 dir = transform.right * horizontal + transform.forward * forward;
        if (dir.sqrMagnitude > 1)
            dir.Normalize();

        rb.MovePosition(transform.position + speedmodifier * Time.fixedDeltaTime * dir);

        // if (Input.GetKeyDown(KeyCode.Space))
        // {
        //     //TODO clean up scale of speed and jump accel
        //     rb.AddForce(Vector3.up * 6, ForceMode.VelocityChange);
        // }
    }
}
