using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColourScores
{
    private int yellowScore;
    private int greenScore;
    private int blueScore;
    private int purpleScore;
  
    public int YellowScore
    {
        get
        {
            return yellowScore;
        }
        set
        {
            yellowScore = value;
        }
    }
    public int GreenScore
    {
        get
        {
            return greenScore;
        }
        set
        {
            greenScore = value;
        }
    }
    public int BlueScore
    {
        get
        {
            return blueScore;
        }
        set
        {
            blueScore = value;
        }
    }
    public int PurpleScore
    {
        get
        {
            return purpleScore;
        }
        set
        {
            purpleScore = value;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
