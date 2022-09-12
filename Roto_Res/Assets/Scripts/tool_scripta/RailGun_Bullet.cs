using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RailGun_Bullet : MonoBehaviour
{
    private float speed = 10f;
   // public breakObject brk;
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
        if(other.gameObject.tag == "Goober")
        {
            Destroy(other.gameObject);
        }
        if(other.gameObject.tag == "break_wall")
        {
            Destroy(other.gameObject);
        }
    }
}
