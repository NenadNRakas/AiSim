using UnityEngine;
using System.Collections;

public class MultiRotorMotion : MonoBehaviour
{
    Rigidbody ourDrone;

    void Awake()
    {
        ourDrone = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        MovementUpDown();
        ourDrone.AddRelativeForce(Vector3.up * upForce);
    }

    public float upForce;

    void MovementUpDown()
    {
        if (Input.GetKey(KeyCode.I))
        {
            upForce = 450;
        }
        else if (Input.GetKey(KeyCode.K))
        {
            upForce = -200;
        }
        else if (!Input.GetKey(KeyCode.I) && !Input.GetKey(KeyCode.K))
        {
            upForce = 98.1;
        }
    }
}
