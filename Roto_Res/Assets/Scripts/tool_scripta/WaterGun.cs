using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class WaterGun : ToolBase_Guns
{
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
    }
}
