using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class WaterGun : MonoBehaviour
{
    public Rigidbody projectile;
    public float speed = 20;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("q"))
        {

            Rigidbody instantiatedProjectile = Instantiate(projectile, transform.position, transform.rotation) as Rigidbody;
            instantiatedProjectile.velocity = transform.TransformDirection(new Vector3(0, 0, speed));
           // Rigidbody instBulletRigidbody = instantiatedProjectile.GetComponent<Rigidbody>();
            // instBulletRigidbody.AddForce(Vector3.right * speed);
        }
    }
    //public void Shoot(InputAction.CallbackContext context)
    //{
        
        
    //        GameObject instantiatedProjectile = Instantiate(projectile, transform.position, transform.rotation) as GameObject;
    //        Rigidbody instBulletRigidbody = instantiatedProjectile.GetComponent<Rigidbody>();
    //    instBulletRigidbody.AddForce(Vector3.right * speed, ForceMode.Force);
        
       
    //}
}
