using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This script prints the name of the objects in the array defined in the inspector.
/// </summary>
public class Two : MonoBehaviour
{
    public GameObject[] objects;
    // Start is called before the first frame update
    void Start()
    {
        foreach(GameObject obj in objects)
        {
            Debug.Log(obj.name);
        }
    }
}
