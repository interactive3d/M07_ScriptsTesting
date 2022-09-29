using System.Collections;
using System.Collections.Generic;
using UnityEngine; // this is an element allowing to use elements of Unity
using UnityEngine.UIElements;

public class MySceneController : MonoBehaviour
{
    public GameObject myObject; // this is a defition for an object of the type GameObject
    public GameObject[] interactables; // an array of the objects


    private void Start()
    {
        //myObject.SetActive(false); // this will make an object called myObject disapear
        // I want to go through each element of interactables array and make it re-scaled.
        /*foreach (GameObject whatEver in interactables)
        {
            whatEver.transform.localScale = 
                new Vector3(whatEver.transform.localScale.x * 2.0f, whatEver.transform.localScale.y * 2.0f, whatEver.transform.localScale.z*2.0f);
        }*/

        
        for (int a = 0; a< interactables.Length; a++)
        {
            Debug.Log("this is " + a + " element of the list");
            // condition
            // only if the name of the object is not Cube
            if (interactables[a].name != "Cube")
            {
                interactables[a].transform.localScale = interactables[a].transform.localScale * 4.0f;
            }
            else
            {

            }
            
        }
        
    }
}
