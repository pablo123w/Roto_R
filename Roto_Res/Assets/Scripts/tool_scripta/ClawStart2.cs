using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ClawStart2 : MonoBehaviour
{
    //reference HeloMovement to get inertia for goober
    private HeloMovement HM;

    public PlayerMain Ply;
    public GameObject Rope;
    private GameObject ObjectAbtInQuestion;
    private GameObject ObjectInQuestion;

    private GameObject TempParent;



    private bool CanGrabSomething = false;

	private void Start()
	{
        HM = Ply.gameObject.GetComponent<HeloMovement>();
	}

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("trigger enter1");
        if (other.CompareTag("Pickupable"))
		{
            CanGrabSomething = true;
            ObjectAbtInQuestion = other.transform.gameObject;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Pickupable"))
		{
            CanGrabSomething = false;
            ObjectAbtInQuestion = null;
        }
    }

    public void Pickup(InputAction.CallbackContext context)
    {
        if (context.started && CanGrabSomething)
        {
            ObjectInQuestion = ObjectAbtInQuestion;
            TempParent = ObjectInQuestion.transform.parent.gameObject;
            ObjectInQuestion.transform.parent = gameObject.transform;
            Rigidbody rb = ObjectInQuestion.GetComponent<Rigidbody>();
            rb.velocity = Vector3.zero;
            rb.useGravity = false;
            rb.isKinematic = true;
        }

        else if (context.canceled)
        {
            if (ObjectInQuestion == null) return;

            Rigidbody rb = ObjectInQuestion.GetComponent<Rigidbody>();
            rb.useGravity = true;
            rb.isKinematic = false;

            ObjectInQuestion.transform.SetParent(TempParent.transform, true);
            
            rb.velocity = (HM.rb.velocity * 3f);
            ObjectInQuestion = null;
            TempParent = null;

        }
    }
}

