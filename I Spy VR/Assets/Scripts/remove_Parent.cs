using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class remove_Parent : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void disconnnect_Parent()
    {
        transform.parent = null;
    }
}
