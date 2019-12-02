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
