using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class WeaponsSwitch : MonoBehaviour
{
    public GameObject tool_1;
    public GameObject tool_3;
    public GameObject tool_2;
   


    void Update()
    {
        switchWeapons();
    }
    public void switchWeapons()
    {
        if (Input.GetKeyDown("v"))
        {
            tool_1.SetActive(true);
            tool_2.SetActive(false);
            tool_3.SetActive(false);
            
        }
        if (Input.GetKeyDown("b"))
        {
            tool_1.SetActive(false);
            tool_2.SetActive(true);
            
        }
        if (Input.GetKeyDown("1"))
        {
            tool_1.SetActive(false);
            tool_2.SetActive(false);
            tool_3.SetActive(true);
        }
        
    }
    public void sWeaponsFirst(InputAction.CallbackContext context)
    {
        tool_1.SetActive(true);
        tool_2.SetActive(false);
        tool_3.SetActive(false);
       
    }
    public void sWeaponsTwo(InputAction.CallbackContext context)
    {
        tool_1.SetActive(false);
        tool_2.SetActive(true);
        tool_3.SetActive(false);
        
    }
    public void sWeaponsThree(InputAction.CallbackContext context)
    {
        tool_1.SetActive(false);
        tool_3.SetActive(true);
        tool_2.SetActive(false);

    }
}
