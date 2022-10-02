using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ToolBase_Guns : MonoBehaviour
{
    public GameObject shot;
    public float shotSpeed;
    public GameObject shotSpawn;
    //[SerializeField]
   // public bool canShoot;
    public float cooldownTime = 1f;

    public void shooting()
    {
        GameObject bullet = (GameObject)Instantiate(shot);
        bullet.transform.position = shotSpawn.transform.position;
        // bullet.GetComponent<Rigidbody>().velocity = Vector3.down * shotSpeed;
        Destroy(bullet, 5f);
    }
}
