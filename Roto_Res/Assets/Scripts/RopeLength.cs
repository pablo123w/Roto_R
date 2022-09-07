using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class RopeLength : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ChangeLength(InputAction.CallbackContext context)
    {
        transform.localScale += new Vector3(0.05f, 0.05f, 0.05f);
    }
    public void MinusLength()
    {
        if (Input.GetKeyDown("x"))
        {
            transform.localScale += new Vector3(-.05f, -.05f, -.05f);
        }
       
    }
}
