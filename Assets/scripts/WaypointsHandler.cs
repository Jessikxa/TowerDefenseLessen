using System.Collections.Generic;
using NUnit.Framework;
using UnityEditor;
using UnityEngine;

public class WaypointsHandler : MonoBehaviour
{

    public static List<Transform> Waypoints = new List<Transform>();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for(int i = 0; i< transform.childCount; i++)
        {
            Waypoints.Add(transform.GetChild(i));
            //print(Waypoints[i].name);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
