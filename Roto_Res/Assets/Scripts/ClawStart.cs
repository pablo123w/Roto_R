using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class ClawStart : MonoBehaviour
{
    public PlayerMain ply;
    public GameObject hook_point;
    public GameObject Rope;
    private GameObject goob;
    Rigidbody Rrgbd;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Goober"))
        {
           
            ply.Score += 1;
           other.transform.parent = hook_point.transform;
            Rrgbd = Rope.GetComponent<Rigidbody>();
            //Rrgbd.freezeRotation = true;
            Rrgbd.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionY;

            //Destroy(other.gameObject);
        }

    }
    private void Update()
    {
        
    }
    

    public void LetGoOfGoober(InputAction.CallbackContext contex)
    {
        if (contex.performed)
        {
            if (goob.transform.IsChildOf(hook_point.transform))
            {
            goob = GameObject.FindWithTag("Goober");
            Rigidbody rg;
            rg = goob.GetComponent<Rigidbody>();
            // transform.SetParent(, true);
            goob.transform.SetParent(null, true);
            rg.useGravity = true;
            rg.isKinematic = false;
            Rrgbd.constraints = RigidbodyConstraints.None;
            }
        }
        
       
    }
}
