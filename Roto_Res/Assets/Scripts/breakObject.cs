using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * ATTACH THIS SCRIPT TO THE OBJECT THAT IS BEING DESTROYED
 */

public class breakObject : MonoBehaviour

{
    // Spawns destroyed prefab
    public Transform destroyedObject;
    // Strength of object
    public float objectStrength;
    // The distance that the force effects the object
    public float objectExplosionRadius;
    // The distance that the "explosion" sends the pieces
    public float explosionPower;
    // The force that sends the broken pieces flying up
    public float upwardsExplosion;
    bool isBroke = false;

    // When object hits the prefab hard enough destroys the object.
    private void OnCollisionEnter(Collision collision)
    {
        // Anything that hits the prefab with greater force than the strength of the object is destroyed.
        while(isBroke == false)
		{
            if (collision.relativeVelocity.magnitude > objectStrength)
            {
                Destroy(gameObject);
                Break();
                //destroyedObject.localScale = transform.localScale;
                //Vector3 explosionPos = transform.position;
                //Collider[] colliders = Physics.OverlapSphere (explosionPos, objectExplosionRadius);

                //foreach (Collider hit in colliders)
                //{
                //    if (hit.attachedRigidbody)
                //    {
                //        hit.attachedRigidbody.AddExplosionForce(explosionPower * collision.relativeVelocity.magnitude, explosionPos, objectExplosionRadius, upwardsExplosion);
                //    }
                //}
            }
        }
    }
    private void Break()
	{
        Instantiate(destroyedObject, transform.position, transform.rotation);
        isBroke = true;
    }
}
