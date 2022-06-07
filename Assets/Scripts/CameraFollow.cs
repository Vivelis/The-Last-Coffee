using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject player;

    [SerializeField]
    private Vector3 cameraPos = new Vector3(15, 7, -10);
    [SerializeField]    [Range(0.01f, 1f)]
    private float smoothSpeed = 0.125f;

    private Vector3 playerPos = new Vector3();
    private Vector3 velocity = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = player.transform.position + cameraPos;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        playerPos = player.transform.position;
        Vector3 desiredPosition = new Vector3 (playerPos.x, playerPos.y, playerPos.z) + cameraPos;
        transform.position = Vector3.SmoothDamp(transform.position, desiredPosition, ref velocity, smoothSpeed);
    }
}
