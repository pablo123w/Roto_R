using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tellDamage : MonoBehaviour
{
	public GameObject daddyGoob;
	goobScript goobScript;
	public float goobStrength = 0;

	private void Start()
	{
		goobScript = daddyGoob.GetComponent<goobScript>();
	}

	private void OnCollisionEnter(Collision other)
	{
		if (goobScript == null) return;
		if (other == null) return;
		if (other.gameObject.CompareTag("Player")) return;

		foreach (Transform transform in daddyGoob.GetComponentsInChildren<Transform>())
		{
			if (transform == other.transform) return;
		}
		if (other.relativeVelocity.magnitude > goobStrength)
		{
			goobScript.TakeDamage(other.relativeVelocity.magnitude);
		}



		//if (other == null) return;
		//if (other.gameObject == null) return;
		//if (other.gameObject.CompareTag("Player")) return;
		//foreach (Transform transform in daddyGoob.transform.GetComponentsInChildren<Transform>())
		//{
		//	if (transform == other.gameObject.transform) return;
		//}

		//if (other.relativeVelocity.magnitude > goobStrength)
		//{
			
		//	goobScript.TakeDamage(other.relativeVelocity.magnitude);
		//}
	}
}
