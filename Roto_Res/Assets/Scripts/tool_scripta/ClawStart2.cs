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
    public Animator Animator;

    private GameObject TempParent;

    private bool CanGrabSomething = false;

	private void Start()
	{
        HM = Ply.gameObject.GetComponent<HeloMovement>();
	}

    private void OnTriggerEnter(Collider other)
    {
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
        if (context.started)
		{
            if (CanGrabSomething)
            {
                {
                    ObjectInQuestion = ObjectAbtInQuestion;

                    goobScript GS = ObjectInQuestion.transform.root.GetComponent<goobScript>();
                    if (GS != null)
                    {
                        GS.IsGrabbed = true;
                    }

                    //check if object has parent or not
                    //TempParent = (ObjectInQuestion.transform.parent.gameObject != null) ? ObjectInQuestion.transform.parent.gameObject : ObjectInQuestion;

                    TempParent = ObjectInQuestion.transform.parent.gameObject;

                    ObjectInQuestion.transform.parent = gameObject.transform;

                    //animate
                    Animator.SetBool("isClosed", true);

                    Rigidbody rb = ObjectInQuestion.GetComponent<Rigidbody>();
                    rb.velocity = Vector3.zero;
                    rb.useGravity = false;
                    rb.isKinematic = true;
                }
            }
            //animate
            Animator.SetBool("isClosed", true);
        }

        else if (context.canceled)
        {
            //animate
            Animator.SetBool("isClosed", false);

            if (ObjectInQuestion == null) return;

            Rigidbody rb = ObjectInQuestion.GetComponent<Rigidbody>();
            rb.useGravity = true;
            rb.isKinematic = false;

            ObjectInQuestion.transform.SetParent(TempParent.transform, true);

            goobScript GS = ObjectInQuestion.transform.root.GetComponent<goobScript>();
            if (GS != null)
            {
                GS.IsGrabbed = false;
            }

            Rigidbody rootrb = ObjectInQuestion.transform.root.gameObject.GetComponent<Rigidbody>();
            if (rootrb != null)
			{
                ObjectInQuestion.transform.root.gameObject.GetComponent<Rigidbody>().velocity = HM.rb.velocity;
            }
			else
			{
                rb.velocity = HM.rb.velocity;
            }

            ObjectInQuestion = null;
            TempParent = null;

        }
    }
}

