using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ChangeCubeColorWithDelegate.onActionButtonClick += ToFallDown;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ToFallDown()
    {
        GetComponent<Rigidbody>().useGravity = true;
    }
}
