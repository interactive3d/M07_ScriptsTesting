using System.Collections;
using System.Collections.Generic;
using UnityEngine; // this is an element allowing to use elements of Unity
public class MySceneController : MonoBehaviour
{
    public int healthValue; // this will store the health value between 0-100 of a player
    public string userName = "Marcin";
    public float yourMoney; // this store the float value for amount of collected gold in the application

    private void Start()
    {
        // Debug.Log("Marcin is the best teacher");
        healthValue = 100;
        yourMoney = 0.0f; 
        Debug.Log(userName + " - your health value is " + healthValue + "%");

        int numberOfClicks = 0;
        numberOfClicks = 10;
        Debug.Log("You have clicked " + numberOfClicks + " times");
    }
}
