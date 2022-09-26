using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterBullet : MonoBehaviour
{
    public GameObject effect;
    private float speed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
    public void Move()
    {
        Vector3 bulletSpeed = Vector3.left * speed;
        transform.Translate(bulletSpeed * Time.deltaTime);
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Fire")
        {
            Destroy(other.gameObject);
        }
        if(other.gameObject.tag == "Wall")
        {
            effect.SetActive(true);
            Rigidbody rg;
             rg = other.GetComponent<Rigidbody>();
            rg.AddForce(-10, 0, 0, ForceMode.Force);
            
        }
       
    }
    public void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "Wall")
        {
            effect.SetActive(false);
        }
    }
}
