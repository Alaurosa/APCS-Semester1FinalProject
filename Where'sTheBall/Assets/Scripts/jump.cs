using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour {
    public GameObject cube;
    public Rigidbody rb;
    public Transform cam;
    // Start is called before the first frame update
    private void Start()
    {
        cube.transform.Translate(Vector3. up *5);
        rb = cube.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void Update()
    {
        cam.LookAt(cube.transform);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * 5, ForceMode.Impulse);
        }

        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(Vector3.forward, ForceMode.Impulse);
        }

        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(Vector3.left, ForceMode.Impulse);
        }

        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(Vector3.back, ForceMode.Impulse);
        }

        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(Vector3.right, ForceMode.Impulse);
        }
    }
}
