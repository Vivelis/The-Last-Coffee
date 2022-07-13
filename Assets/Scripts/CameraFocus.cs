using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFocus : MonoBehaviour
{
    [SerializeField]
    private float smoothSpeed = 0f;
    [SerializeField]
    private GameObject target;
    [SerializeField]
    private Vector3 offset = Vector3.zero;

    private Vector3 velocity = Vector3.zero;

    // Update is called once per frame
    void Update()
    {
        FollowObject(target, offset);
    }

    private void FollowObject(GameObject _target)
    {
        transform.position = Vector3.SmoothDamp(transform.position, _target.transform.position, ref velocity, smoothSpeed);
    }

    private void FollowObject(GameObject _target, Vector3 offset)
    {
        transform.position = Vector3.SmoothDamp(transform.position, _target.transform.position + offset, ref velocity, smoothSpeed);
    }
}
