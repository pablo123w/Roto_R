using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class WaterGun : ToolBase_Guns
{
    Vector2 targetPosition;
    public GameObject gunPivot;
    private GameObject gunEnd;
    public bool wes;
    private bool canShoot;
    public void Start()
    {
       // gunPivot = GameObject.Find("gunPivot");
       // gunEnd = GameObject.Find("water_gun_box");
    }
    public void Update()
    {
        if (Input.GetKeyDown("l"))
        {
            shooting();
        }
    }
   
    public void Fire(InputAction.CallbackContext context)
    {
        shooting();
        //if (wes == true)
        //{
        //    shooting();
        //}

    }
    //public void Aim(InputAction.CallbackContext context)
    //{
    //    if (context.performed)
    //    {
    //        targetPosition = context.ReadValue<Vector2>();
    //        if (targetPosition.y < 0)
    //            gunPivot.transform.localRotation = Quaternion.FromToRotation(gunPivot.transform.position, targetPosition);
    //        else if (targetPosition.y > 0 && targetPosition.x < 0)
    //            gunPivot.transform.localRotation = Quaternion.FromToRotation(gunPivot.transform.position, Vector3.left);
    //        else if (targetPosition.y > 0 && targetPosition.x > 0)
    //            gunPivot.transform.localRotation = Quaternion.FromToRotation(gunPivot.transform.position, Vector3.right);
    //    }
    //}
}
