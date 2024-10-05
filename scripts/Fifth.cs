using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fifth : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject cube = GameObject.Find("rojoCubo");
        GameObject cilinder = GameObject.Find("azulCilindro");
        Debug.Log("Distancia de esfera a cubo: " + Vector3.Distance(transform.position, cube.transform.position));
        Debug.Log("Distancia de esfera a cilindro: " + Vector3.Distance(transform.position, cilinder.transform.position));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
