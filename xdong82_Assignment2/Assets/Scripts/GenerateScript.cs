using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateScript : MonoBehaviour
{
    private int numCubes;
    public GameObject cubePrefabVar;
   

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i <= 8; i++)
        {
            if(i < 4)
            {
                GameObject gObj = Instantiate<GameObject>(cubePrefabVar);
                gObj.tag = "Pick Up Yellow";
                Color c = new Color(255, 255, 0);
                gObj.GetComponent<Renderer>().material.color = c;
                if(i < 3)
                {
                    Vector3 p = new Vector3(i * 5, 1.16f, 0);
                    setPosition(gObj, p);
                }
               
                if(i == 3)
                {
                    Vector3 p = new Vector3(5, 1.16f, 10);
                    setPosition(gObj, p);
                }
                
                

            }
            if((i < 5) && (i >= 3)){
                GameObject gObj = Instantiate<GameObject>(cubePrefabVar);
                gObj.tag = "Pick Up Blue";
                Color c = new Color(0, 0, 255);
                gObj.GetComponent<Renderer>().material.color = c;
                Vector3 p = new Vector3(0 , 1.16f, (i*5)-10);
                gObj.transform.position = p;
            }
            if ((i < 8) && (i >= 5))
            {
                GameObject gObj = Instantiate<GameObject>(cubePrefabVar);
                gObj.tag = "Pick Up Green";
                Color c = new Color(0, 255, 0);
                gObj.GetComponent<Renderer>().material.color = c;
                if(i < 7)
                {
                    Vector3 p = new Vector3(10, 1.16f, (i * 5) - 20);
                    setPosition(gObj, p);
                }
                if(i == 7)
                {
                    Vector3 p = new Vector3(13, 1.16f, 10);
                    setPosition(gObj, p);
                }
               
               
            }
            if (i >= 8)
            {
                GameObject gObj = Instantiate<GameObject>(cubePrefabVar);
                gObj.tag = "Pick Up Purple";
                Color c = new Color(200, 0, 255);
                gObj.GetComponent<Renderer>().material.color = c;
                Vector3 p = new Vector3(13, 1.16f, 5);
                   
                gObj.transform.position = p;
            }
         
        }

    }

    void setPosition(GameObject obj, Vector3 pos)
    {
        obj.transform.position = pos;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
