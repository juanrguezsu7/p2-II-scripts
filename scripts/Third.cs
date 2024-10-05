using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Third : MonoBehaviour
{
    public Vector3 firstVector;
    public Vector3 secondVector;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Magnitude of firstVector: " + firstVector.magnitude);
        Debug.Log("Magnitude of secondVector: " + secondVector.magnitude);
        Debug.Log("Angle between firstVector and secondVector: " + Vector3.Angle(firstVector, secondVector));
        Debug.Log("Distance between firstVector and secondVector: " + Vector3.Distance(firstVector, secondVector));
        if (firstVector.y > secondVector.y)
        {
            Debug.Log("firstVector is higher than secondVector");
        }
        else if (firstVector.y < secondVector.y)
        {
            Debug.Log("secondVector is higher than firstVector");
        }
        else
        {
            Debug.Log("firstVector and secondVector are at the same height");
        }
    }
}
