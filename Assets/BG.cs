using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BG : MonoBehaviour
{
    Vector3 startPos;
    float rw;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        rw = gameObject.GetComponent<Renderer>().bounds.size.x / 2;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < startPos.x - rw)
        {
            transform.position = startPos;
        }
    }
}
