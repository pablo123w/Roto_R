using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClawStart : MonoBehaviour
{
    public PlayerMain ply;
    public Transform hook_point;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Goober"))
        {
           
            ply.Score += 1;
           other.transform.parent = hook_point.transform;
            //Destroy(other.gameObject);
        }

    }
}
