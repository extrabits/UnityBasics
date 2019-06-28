using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody rb;
    public Vector3 spawnPosition;
    public float jumpForce = 300;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        spawnPosition = new Vector3(0, 1, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z < -2.5 || transform.position.y < -1)
            transform.position = spawnPosition;
        if (Input.GetKeyDown("space") && transform.position.y < 1.1)
            rb.AddForce(0, jumpForce, 0);
    }
}
