using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sixth : MonoBehaviour
{
    public GameObject[] firstObjectDestiny = new GameObject[2];
    public GameObject[] secondObjectDestiny = new GameObject[2];
    public GameObject[] thirdObjectDestiny = new GameObject[2];
    Transform[] firstTransform = new Transform[2];
    Transform[] secondTransform = new Transform[2];
    Transform[] thirdTransform = new Transform[2];
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 2; i++)
        {
            firstTransform[i] = firstObjectDestiny[i].transform;
            secondTransform[i] = secondObjectDestiny[i].transform;
            thirdTransform[i] = thirdObjectDestiny[i].transform;
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            firstTransform[0].Translate(firstTransform[1].position);
            secondTransform[0].Translate(secondTransform[1].position);
            thirdTransform[0].Translate(thirdTransform[1].position);
        }
    }
}
