using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public float Points;
    public Text pointsDisplay;
    public GameObject Key;

    private void Start()
    {
        Key.SetActive(false);
    }
    void Update()
    {

        print(Points);

        pointsDisplay.text = Points.ToString();
        if (Points >= 1000)
        {
            Spawn();
        }
    }

    void Spawn()
    {
            Key.SetActive(true);
    }    
}