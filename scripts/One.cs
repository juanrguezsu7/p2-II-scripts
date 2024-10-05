using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This script changes a component of the Cube object every (default) 120 frames.
/// </summary>
public class One : MonoBehaviour
{ 
    [Tooltip("Number of frames to update the color of the object.")]
    public ushort updateFrames = 120;
    ushort actualFrames = 0;
    Vector3 colorVector;
    Color color;
    Renderer rd;
    // Start is called before the first frame update
    void Start()
    {
        colorVector = new Vector3(Random.value, Random.value, Random.value);
        color = new Color(colorVector.x, colorVector.y, colorVector.z);
        rd = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log("Actual framerate: " + 1 / Time.deltaTime);
        if (actualFrames == updateFrames)
        {
            int randomPosition = Random.Range(0, 3);
            colorVector[randomPosition] = Random.value;
            color = new Color(colorVector.x, colorVector.y, colorVector.z);
            rd.material.color = color;
            actualFrames = 0;
        }
        actualFrames++;
    }
}
