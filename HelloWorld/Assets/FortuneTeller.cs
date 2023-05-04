using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FortuneTeller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int highestGuessPossible = 5000;
        int minimumGuessPossible = 1;
        Debug.Log("Welcome to my shack, care to play game?");
        Debug.Log("Pick a number, but don't tell me what it is");
        Debug.Log("The highest number you can pick is : " + highestGuessPossible);
        Debug.Log("The lower number you can pick is : " + minimumGuessPossible);
        Debug.Log("Tell me if your guess is higher or lower than 2500");
        Debug.Log("Press up = higher, Press down = lower, Press Enter = Correct");
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("Up Arrow was pressed");
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("Down Arrow was pressed");
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Enter Arrow was pressed");
        }
        
    }
}