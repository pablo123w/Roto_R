using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class WeaponsSwitch : MonoBehaviour
{
    public GameObject tool_1;
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
        if (Input.GetKeyDown("v"))
        {
            tool_1.SetActive(true);
            tool_2.SetActive(false);
        }
        if (Input.GetKeyDown("b"))
        {
            tool_1.SetActive(false);
            tool_2.SetActive(true);
        }
        //for (int i = 1; i <= nrWeapons; i++)
        //{
        //    if (Input.GetKeyDown("v"))
        //    {
        //        i++;
        //        currentWeapon = i - 1;

        //        SwitchWeapon(currentWeapon);

        //    }
        //    if(Input.GetKeyDown("b"))
        //    {
        //        i--;
        //        currentWeapon = i - 1;

        //        SwitchWeapon(currentWeapon);

        //    }
        //}
    }

    //void SwitchWeapon(int index)
    //{

    //    for (int i = 0; i < nrWeapons; i++)
    //    {
    //        if (i == index)
    //        {
    //            weapons[i].gameObject.SetActive(true);
    //        }
    //        else
    //        {
    //            weapons[i].gameObject.SetActive(false);
    //        }
    //    }
    //}

}
