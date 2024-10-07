using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sixth : MonoBehaviour
{
    public Vector3 objective;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      if (Input.GetAxis("Jump") > 0) {
        transform.Translate(objective * Time.deltaTime, Space.Self);
      }
    }
}
