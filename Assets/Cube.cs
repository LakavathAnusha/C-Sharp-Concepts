using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ChangeCubeColorWithDelegate.onActionButtonClick+=TurnRed;
        //ChangeCubeColorWithDelegate.onActionButtonClick-=
    }
    public void TurnRed()
    {
        GetComponent<MeshRenderer>().material.color = Color.red;
    }
    public void TurnBlue()
    {
        GetComponent<MeshRenderer>().material.color = Color.blue;
    }
    public void OnDisable()
    {
        Debug.Log("Disable Indisable Method");
        ChangeCubeColorWithDelegate.onActionButtonClick += TurnRed;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
