using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seventh : MonoBehaviour
{
    GameObject cube;
    GameObject cilinder;
    // Start is called before the first frame update
    void Start()
    {
        cube = GameObject.Find("rojoCubo");
        cilinder = GameObject.Find("azulCilindro");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C)) {
            ChangeColor(ref cube);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            ChangeColor(ref cilinder);
        }
    }

    void ChangeColor(ref GameObject obj)
    {
        obj.GetComponent<Renderer>().material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
    }
}
