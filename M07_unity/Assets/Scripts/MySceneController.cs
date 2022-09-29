using System.Collections;
using System.Collections.Generic;
using UnityEngine; // this is an element allowing to use elements of Unity
public class MySceneController : MonoBehaviour
{
    public int healthValue; // this will store the health value between 0-100 of a player
    public string userName = "Marcin";
    public float yourMoney; // this store the float value for amount of collected gold in the application

    public string[] artifacts = {"Cup", "Gold Coin", "Treasure Chest"}; // this will store elements that user collects in the game

    public string[] otherUsers;

    private void Start()
    {
        // Debug.Log("Marcin is the best teacher");
        healthValue = 100;
        yourMoney = 0.0f; 
        Debug.Log(userName + " - your health value is " + healthValue + "%");

        int numberOfClicks = 0;
        numberOfClicks = 10;
        Debug.Log("You have clicked " + numberOfClicks + " times");

        string myArtifactsToCollect = ""; // this is currently an empty string type data
        
        // this loop will go over each element of the array called artifacts
        for (int i = 0; i< artifacts.Length; i++)
        {
            myArtifactsToCollect = myArtifactsToCollect + artifacts[i] + ", ";
        }

        Debug.Log("You task in the game is to collect " + myArtifactsToCollect);

        /*
         * Create an array that consist "Cup", "Gold Coin", "Treasure Chest"
         * At the start of the game. Display a message "You task in the game is to find: "  + elements of the array
         */
    }
}
