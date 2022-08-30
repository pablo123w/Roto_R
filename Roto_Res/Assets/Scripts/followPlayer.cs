using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPlayer : MonoBehaviour
{
    public Transform player;
    private Vector3 camOffset = new Vector3(0, -2, -15);
    void Update()
    {
        transform.position = player.transform.position + camOffset;
    }
}
