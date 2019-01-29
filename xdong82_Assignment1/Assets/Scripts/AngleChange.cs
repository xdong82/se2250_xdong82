using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AngleChange : MonoBehaviour
{
    public GameObject base1;
    public float speed = 200f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rotate();
        }

    }

    private void rotate()
    {
        transform.RotateAround(base1.transform.position, Vector3.up, speed);
        transform.RotateAround(base1.transform.position, Vector3.left, speed);

    }
}
