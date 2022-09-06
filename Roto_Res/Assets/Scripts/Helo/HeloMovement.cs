using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class HeloMovement : MonoBehaviour
{
    public Rigidbody rb;

    private float lHorizontal;
	private float lVertical;
	public float maxSpeed = 8f;
	public float speed = 2f;

	//autostabilize after rotating off center
	public float stability = 0.3f;
	public float stabilityspeed = 2.0f;

	//animate rotation with movement
	float rotatesmooth = 1f;
	float tiltAngle = -15f;



	void Update()
	{
		rb = GetComponent<Rigidbody>();
		rb.AddRelativeForce(lHorizontal * speed, lVertical * speed, 0, ForceMode.Acceleration);

		//rotate helo with movement
		float tiltAroundZ = lHorizontal * tiltAngle;
		Quaternion target = Quaternion.Euler(0, 0, tiltAroundZ);
		transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * rotatesmooth);

		//cap max speed for helicopter
		//Debug.Log(rb.velocity.magnitude);
		if (rb.velocity.magnitude > maxSpeed)
		{
			rb.velocity = Vector3.ClampMagnitude(rb.velocity, maxSpeed);
		}

    }

	private void FixedUpdate()
	{
		Vector3 predictedUp = Quaternion.AngleAxis(
		 rb.angularVelocity.magnitude * Mathf.Rad2Deg * stability / speed,
		 rb.angularVelocity
	 ) * transform.up;

		Vector3 torqueVector = Vector3.Cross(predictedUp, Vector3.up);
		rb.AddTorque(torqueVector * speed * speed);
	}

	public void Move(InputAction.CallbackContext context)
	{
        lHorizontal = context.ReadValue<Vector2>().x;
		lVertical = context.ReadValue<Vector2>().y;
	}

}
