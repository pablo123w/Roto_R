using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bomb : MonoBehaviour
{
    public float expForce, radius;
	public float objectStrength;

	private void OnCollisionEnter(Collision other)
	{
		if (other.relativeVelocity.magnitude > objectStrength)
		{
			knockback();
			Destroy(gameObject);
		}
	}

	void knockback()
	{
		Collider[] colliders = Physics.OverlapSphere(transform.position, radius);

		foreach(Collider nearby in colliders)
		{
			//if(colliders.gameObject.tag == "Destructible")
			//{

			//}
			Rigidbody rb = nearby.GetComponent<Rigidbody>();
			if(rb != null)
			{
				rb.AddExplosionForce(expForce, transform.position, radius);
			}
		}
	}
}
