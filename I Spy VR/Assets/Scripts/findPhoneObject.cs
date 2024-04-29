using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    emptyScript[] foundObjectList;
    emptyScript foundMailbox;
    emptyScript foundText;

    [SerializeField]GameObject objectFound;

    int timesPickedUp = 0;
    // Start is called before the first frame update
    void Start()
    {
        findObjects();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void findObjects(){
        if (timesPickedUp == 0){

            print("Yaaaaay!");
            foundObjectList = FindObjectsOfType<emptyScript>();
            foundMailbox = foundObjectList[0];
            foundText = foundObjectList[1];
            timesPickedUp ++;
        }
    }

    public void positionSimilar()
    {
        print("Yaaaaay!232");
        // This will take the distance from the found object and compare to the mailbox to see if it is close enough 
        float distance = Vector3.Distance (objectFound.transform.position, foundMailbox.gameObject.transform.position);
        if(distance <= 1f)
        {
            foundText.gameObject.SetActive(false);
        }
    }


}
