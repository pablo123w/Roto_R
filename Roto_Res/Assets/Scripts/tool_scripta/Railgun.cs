using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class Railgun : ToolBase_Guns
{
    Vector2 targetPosition;

    private Vector3 maxAngle = Vector3.one * 2;
    public GameObject gunPivot;
    private GameObject gunEnd;
    public float rand;
    public float amp;
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
   
    public void KickBack()
    {
        transform.localRotation = Quaternion.Euler(new Vector3(maxAngle.x * (Mathf.PerlinNoise(rand + 3, Time.time * amp) * 2 - 1), 0, 0));
    }

   public void Fire(InputAction.CallbackContext context)
    {
        shooting();
    }
    //public void aim(InputAction.CallbackContext context)
    //{
    //    targetPosition = context.ReadValue<Vector2>();
    //    if (targetPosition.y < 0)
    //        gunPivot.transform.localRotation = Quaternion.FromToRotation(gunPivot.transform.position, targetPosition);
    //    else if (targetPosition.y > 0 && targetPosition.x < 0)
    //        gunPivot.transform.localRotation = Quaternion.FromToRotation(gunPivot.transform.position, Vector3.left);
    //    else if (targetPosition.y > 0 && targetPosition.x > 0)
    //        gunPivot.transform.localRotation = Quaternion.FromToRotation(gunPivot.transform.position, Vector3.right);
    //}

}       
    

