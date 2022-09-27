using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class Railgun : ToolBase_Guns
{
    Vector2 targetPosition;


    public GameObject gunPivot;
    private GameObject gunEnd;
    // Start is called before the first frame update
    void Start()
    {
        gunPivot = GameObject.Find("gunPivot");
        gunEnd = GameObject.Find("gunEnd");
        

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("l"))
        {
            shooting();
           
            

        }

    }
   

   public void Fire(InputAction.CallbackContext context)
    {
        shooting();
    }
    public void aim(InputAction.CallbackContext context)
    {
        targetPosition = context.ReadValue<Vector2>();
        if (targetPosition.y < 0)
            gunPivot.transform.localRotation = Quaternion.FromToRotation(gunPivot.transform.position, targetPosition);
        else if (targetPosition.y > 0 && targetPosition.x < 0)
            gunPivot.transform.localRotation = Quaternion.FromToRotation(gunPivot.transform.position, Vector3.left);
        else if (targetPosition.y > 0 && targetPosition.x > 0)
            gunPivot.transform.localRotation = Quaternion.FromToRotation(gunPivot.transform.position, Vector3.right);
    }

}       
    

