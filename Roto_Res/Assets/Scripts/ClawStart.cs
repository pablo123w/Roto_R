using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class ClawStart : MonoBehaviour
{
    public PlayerMain ply;
    public Transform hook_point;
    public Transform Rope;
    private GameObject goob;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Goober"))
        {
            ply.Score += 1;
           other.transform.parent = hook_point.transform;

            //Destroy(other.gameObject);
        }

    }
    public void LetGoOfGoober(InputAction.CallbackContext context)
    {
        goob = GameObject.FindWithTag("Goober");
        Rigidbody rg;
        rg = goob.GetComponent<Rigidbody>();
       // transform.SetParent(, true);
       goob.transform.SetParent(null, true);
        rg.useGravity = true;
    }
}
