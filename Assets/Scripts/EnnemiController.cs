using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemiController : MonoBehaviour
{
    private GameObject player;
    private Rigidbody enemyRb;
    private Transform playerTransform;
    private Animator animator;

    public float speed = 1f;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerTransform = player.transform;
        enemyRb = GetComponent<Rigidbody>();
        animator = transform.GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // mouvement de l'ennemi
        MoveTo(player.transform.position);
        transform.LookAt(playerTransform);

        // animator
        animator.SetFloat("Speed_f", enemyRb.velocity.magnitude);
    }

    private void MoveTo(Vector3 position)
    {
        Vector3 lookDirection = (position - transform.position).normalized;
        enemyRb.AddForce(lookDirection * speed);

    }
}
