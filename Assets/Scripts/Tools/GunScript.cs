using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunScript : MonoBehaviour, IUseable
{
    public Transform firePoint;
    
    public void Use1()
    {
        RaycastHit hit;
        if (Physics.Raycast(firePoint.position, transform.forward, out hit))
        {
            IShooteable shooteable = hit.collider.gameObject.GetComponent<IShooteable>();
            if (shooteable != null)
            {
                shooteable.Shoot();
            }
        }
    }

    public void Use2()
    {
        Debug.Log("WATCH OUT HES GOT A GUN");
    }

    private void OnDrawGizmos()
    {
        Debug.DrawRay(firePoint.position, transform.forward * 50, Color.red);
    }
}