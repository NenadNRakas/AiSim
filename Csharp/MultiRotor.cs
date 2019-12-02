using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MultiRotorMotion : MonoBehaviour
{
    Rigidbody ourDrone;
    // Start is called before the first frame update
    void Start()
    {
        ourDrone = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        MovementUpDown();
        ourDrone.AddRelativeForce(Vector3.up * upForce);
    }

    // Determain Force Algorithms
    public float upForce;
    void MovementUpDown()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            upForce = 450;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            upForce = -200;
        }
        else if (!Input.GetKey(KeyCode.Q) && !Input.GetKey(KeyCode.A))
        {
            upForce = 98.1f;
        }
    }
}
