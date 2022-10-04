using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIPrompts : MonoBehaviour
{
    public GameObject uiObject;
    // Start is called before the first frame update
    void Start()
    {
        uiObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider player)
    {
        if(player.gameObject.tag=="Player")
        {
            uiObject.SetActive(true);
            //StartCoroutine("waitForSec");
        }

    }
    private void OnTriggerExit(Collider player)
    {
        if(player.gameObject.tag=="Player")
        {
            uiObject.SetActive(false);
        }
    }
    //IEnumerator WaitForSec()
    //{
    //yield return new WaitForSeconds(5);
    //Destroy(uiObject);
    //Destroy(gameObject);
    //}

    // Update is called once per frame
    //void Update()
    //{
    //Object.SetActive(false);

    //}

    //void OnTriggerEnter()
    //{
    //  Object.SetActive(true);
    // }

    //void OnTriggerExit()
    //{
    //Object.SetActive(false);
    //}
}
