using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    public float expForce, radius;
	public float objectStrength;

	private breakObject breakObj;
	private colliderContainer nearList;
	

	private void OnCollisionEnter(Collision other)
	{
		if (other.relativeVelocity.magnitude > objectStrength)
		{
			foreach (Collider obj in nearList.destructibles)
			{
				breakObj.Break();
				Debug.Log("break destructibles");
			}
			knockback();
			Destroy(gameObject);
		}
	}

	void knockback()
	{
		
		Collider[] colliders = Physics.OverlapSphere(transform.position, radius);
		
		foreach (Collider nearby in colliders)
		{
			Rigidbody rb = nearby.GetComponent<Rigidbody>();
			Debug.Log("get rb");

			if (rb != null)
			{
				rb.AddExplosionForce(expForce, transform.position, radius);
				Debug.Log("add expl force");
			}
		}
	}
}
