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
		if (other.relativeVelocity.magnitude > goobStrength)
		{
			goobScript.TakeDamage(other.relativeVelocity.magnitude);
		}
	}
}
