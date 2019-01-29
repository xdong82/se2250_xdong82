using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class posReset : MonoBehaviour
{
    public Vector3 startPosition;


    void Awake()
    {
        startPosition = transform.position;
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, 100.0f))
            {
                if (hit.transform != null)
                {
                    Rigidbody rb;
                    if(rb = hit.transform.GetComponent<Rigidbody>())
                    {
                        reset(rb);
                    }
                }
            }
        }
    }

    private void reset(Rigidbody rb)
    {
        rb.transform.position = startPosition;
    }
}

    

