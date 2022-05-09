using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public float Points;
    public Text pointsDisplay;
    
    void Update()
    { 
        
       print(Points);
       
      pointsDisplay.text = Points.ToString();

            
        
    }

}