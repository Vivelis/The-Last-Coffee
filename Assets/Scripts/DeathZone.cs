using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZone : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider entity)
    {
        Debug.Log("Destroyed Object : " + entity.gameObject.name);
        Destroy(entity.gameObject);
    }
}
