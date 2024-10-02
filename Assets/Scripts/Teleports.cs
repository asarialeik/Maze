using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleports : MonoBehaviour
{
    [SerializeField]
    GameObject player;
    [SerializeField]
    GameObject teleportTo;

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            player.transform.position = teleportTo.transform.position;
        }
        
    }
}
