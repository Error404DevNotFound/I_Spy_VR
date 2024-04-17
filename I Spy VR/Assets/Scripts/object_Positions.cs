using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class object_Positions : MonoBehaviour
{
    [SerializeField] GameObject objectFound;
    [SerializeField] GameObject objectPlace;
    [SerializeField] GameObject text;



// This function will determin if the object is close enough, if so then the text is deleted.
    public void positionSimilar()
    {
        float distance = Vector3.Distance (objectFound.transform.position, objectPlace.transform.position);
        if(distance <= 1f)
        {
            text.SetActive(false);
        }
    }

}
