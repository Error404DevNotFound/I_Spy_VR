using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class parent_Manager : MonoBehaviour
{

    [SerializeField] private GameObject phoneObject;
    [SerializeField] private GameObject movedToObject;
    [SerializeField] private GameObject parentObject;
    [SerializeField] private int number_Spawned = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void spawnObject() {
        transform.parent = null;
        if (number_Spawned == 0){
            GameObject phone = Instantiate(phoneObject,movedToObject.transform.position,movedToObject.transform.rotation);
            phone.transform.parent = parentObject.transform;
            number_Spawned = number_Spawned + 1;
        // If we do not want to spawn more...STOP
        }
        else
        {
            return;
        }
        
    }
}
