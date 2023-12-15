using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D bird;
    public float flapStreangth;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Check for spacebar press
        if (Input.GetKeyDown(KeyCode.Space) == true )
        {
            // Move bird up
            bird.velocity = Vector3.up * flapStreangth;
        }
    }
}
