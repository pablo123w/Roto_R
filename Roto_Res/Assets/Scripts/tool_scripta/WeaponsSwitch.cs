using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class WeaponsSwitch : MonoBehaviour
{
    public GameObject tool_1;
    public GameObject tool_1_1;
    public GameObject tool_1_2;
    public GameObject tool_2;
    // public GameObject tool_3;
    //  public GameObject tool_4;

    //public GameObject[] weapons; // push your prefabs

  //  public int currentWeapon = 0;

 //   private int nrWeapons;

    void Start()
    {

      

        

    }

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
            tool_1_1.SetActive(false);
            tool_1_2.SetActive(false);
        }
        if (Input.GetKeyDown("b"))
        {
            tool_1.SetActive(false);
            tool_2.SetActive(true);
            tool_1_1.SetActive(false);
            tool_1_2.SetActive(false);
        }
        if (Input.GetKeyDown("1"))
        {
            tool_1.SetActive(false);
            tool_2.SetActive(false);
            tool_1_1.SetActive(true);
            tool_1_2.SetActive(false);
          
        }
        if (Input.GetKeyDown("2"))
        {
            tool_1.SetActive(false);
            tool_2.SetActive(false);
            tool_1_2.SetActive(true);
            tool_1_1.SetActive(false);
            
        }
    }
    public void sWeaponsFirst(InputAction.CallbackContext context)
    {
        tool_1.SetActive(true);
        tool_2.SetActive(false);
        tool_1_1.SetActive(false);
        tool_1_2.SetActive(false);
    }
    public void sWeaponsTwo(InputAction.CallbackContext context)
    {
        tool_1.SetActive(false);
        tool_2.SetActive(true);
        tool_1_1.SetActive(false);
        tool_1_2.SetActive(false);
    }
}
