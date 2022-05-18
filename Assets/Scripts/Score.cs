using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
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
        if (Points >= 10000)
        {
            Spawn();
        }
        if(Points >= 200000)
        {
            SceneManager.LoadScene(2);
        }
    }

    void Spawn()
    {
            Key.SetActive(true);
    }    
}