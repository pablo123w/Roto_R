using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClawStart : MonoBehaviour
{
    public PlayerMain ply;
    private void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Goober"))
        {
           
            ply.Score += 1;
           other.transform.parent = gameObject.transform;
            //Destroy(other.gameObject);
        }

    }
}
