using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(HingeJoint))]
public class DoorOpener : MonoBehaviour
{
    [SerializeField]
    private float direction = 0f;
    [SerializeField]
    private float rotationForce = 10f;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision == null)
            return;
        Debug.Log(collision.gameObject.tag);
        if (collision.gameObject.tag == "Player")
            OpenDoor();
    }

    private void OpenDoor()
    {
        gameObject.GetComponent<Rigidbody>().AddTorque(new Vector3(0, rotationForce, 0), ForceMode.Impulse);
    }
}
