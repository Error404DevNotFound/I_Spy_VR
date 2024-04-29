using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class object_Positions : MonoBehaviour
{
    // Object we are looking for aka phone or duck
    [SerializeField] GameObject objectFound;
    // The place where the object needs to go, aka the mailbox
    [SerializeField] GameObject objectPlace;
    // The text that needs to be destroyed in the scene
    [SerializeField] GameObject text;



// This function will determin if the object is close enough, if so then the text is deleted.
    public void positionSimilar()
    {
        // This will take the distance from the found object and compare to the mailbox to see if it is close enough 
        float distance = Vector3.Distance (objectFound.transform.position, objectPlace.transform.position);
        if(distance <= 1f)
        {
            text.SetActive(false);
        }
    }

}
