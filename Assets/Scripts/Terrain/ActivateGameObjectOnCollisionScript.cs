using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ActivateGameObjectOnCollisionScript : MonoBehaviour
{
    public GameObject gameObject;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            gameObject.SetActive(true);
        }
    }
}
