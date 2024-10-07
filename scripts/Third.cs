using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Third : MonoBehaviour
{
    public Vector3 firstVector;
    public Vector3 secondVector;
    public double magnitudeFirstVector;
    public double magnitudeSecondVector;
    public double angleBetweenVectors;
    public double distanceBetweenVectors;
    public string higherVector;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Magnitude of firstVector: " + firstVector.magnitude);
        magnitudeFirstVector = firstVector.magnitude;
        Debug.Log("Magnitude of secondVector: " + secondVector.magnitude);
        magnitudeSecondVector = secondVector.magnitude;
        Debug.Log("Angle between firstVector and secondVector: " + Vector3.Angle(firstVector, secondVector));
        angleBetweenVectors = Vector3.Angle(firstVector, secondVector);
        Debug.Log("Distance between firstVector and secondVector: " + Vector3.Distance(firstVector, secondVector));
        distanceBetweenVectors = Vector3.Distance(firstVector, secondVector);
        if (firstVector.y > secondVector.y)
        {
            Debug.Log("firstVector is higher than secondVector");
            higherVector = "First Vector";
        }
        else if (firstVector.y < secondVector.y)
        {
            Debug.Log("secondVector is higher than firstVector");
            higherVector = "Second Vector";
        }
        else
        {
            Debug.Log("firstVector and secondVector are at the same height");
            higherVector = "Same Height";
        }
    }
}
