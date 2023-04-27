using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class LaserScript : MonoBehaviour
{
    
    [Header("Laser System")]
    public Transform shootPoint;
    public LineRenderer lineRenderer;
    
    [Header("Patrol System")]
    public Transform pathParent;
    public float speed;

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(shootPoint.position, shootPoint.up, out hit))
        {
            // Affichage
            Vector3[] pos = new Vector3[2];
            pos[0] = shootPoint.position;
            pos[1] = hit.point;

            lineRenderer.SetPositions(pos);

            if (hit.collider.gameObject.tag == "Player")
            {
                Debug.Log("Insert death code here");
            }
        }
        else
        {
            lineRenderer.SetPositions(new Vector3[0]);
        }
    }
}
