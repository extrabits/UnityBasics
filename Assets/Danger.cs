using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Danger : MonoBehaviour
{
    public Vector3 spawnPosition;
    public float Speed = 17;
    // Start is called before the first frame update
    void Start()
    {
        spawnPosition = new Vector3(0, 1, 35);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z < -10) {
            spawnPosition.z = Random.Range(35, 45);
            transform.position = spawnPosition;
        }
        transform.Translate(-Vector3.forward * Time.deltaTime * Speed);
    }
}
