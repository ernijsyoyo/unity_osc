using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class positionUpdate : MonoBehaviour
{
    public bool test = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(test) {
            print("Rotation of " + gameObject.name + ": " + gameObject.transform.rotation.eulerAngles);
        }
    }
}
