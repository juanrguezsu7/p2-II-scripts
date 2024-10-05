using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eighth : MonoBehaviour
{
    GameObject[] type2Spheres;
    GameObject cube;
    public float velocity;
    // Start is called before the first frame update
    void Start()
    {
        type2Spheres = GameObject.FindGameObjectsWithTag("tipo2");
        cube = GameObject.Find("rojoCubo");
    }

    // Update is called once per frame
    void Update()
    {
        float lowestDistance = Mathf.Infinity;
        float highestDistance = 0f;
        GameObject closestSphere = null;
        GameObject furthestSphere = null;
        foreach (GameObject sphere in type2Spheres) {
            float actualDistance = Vector3.Distance(cube.transform.position, sphere.transform.position);
            if (actualDistance < lowestDistance) {
                lowestDistance = actualDistance;
                closestSphere = sphere;
            }
            if (actualDistance > highestDistance) {
                highestDistance = actualDistance;
                furthestSphere = sphere;
            }
        }
        closestSphere.transform.Translate(Vector3.up * velocity * Time.deltaTime, Space.World);
        if (Input.GetKeyDown(KeyCode.Space)) {
            ChangeColor(ref furthestSphere);
        }
    }

    void ChangeColor(ref GameObject sphere) {
        sphere.GetComponent<Renderer>().material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
    }
}
