using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public class Collectable : MonoBehaviour
{
    public enum e_Collectable
    {
        CoffeePot,
        PowerUp
    }
    public e_Collectable type;

    [SerializeField]
    private float rotateSpeed = 75f;
    [SerializeField]
    private float translateSpeed = 0.3f;

    [SerializeField]
    private float translateDistance = 0.5f;

    private Vector3 startPos;
    private Vector3 endPos;
    private bool goUp;

    private void Start()
    {
        startPos = transform.position;
        endPos = startPos + Vector3.up * translateDistance;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y <= startPos.y)
            goUp = true;
        if (transform.position.y >= endPos.y)
            goUp = false;
        if (goUp == true)
            transform.Translate(Vector3.up * translateSpeed * Time.deltaTime);
        else
            transform.Translate(Vector3.up * translateSpeed * Time.deltaTime * -1);
        transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log($"use: {type}");
            Destroy(gameObject);
        }
    }
}
